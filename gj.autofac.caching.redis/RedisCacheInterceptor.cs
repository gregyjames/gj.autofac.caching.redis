using System.Reflection;
using Castle.DynamicProxy;
using Microsoft.Extensions.Logging;
using StackExchange.Redis;

namespace gj.autofac.caching.redis;

public class RedisCacheInterceptor(ILogger<RedisCacheInterceptor> logger, RedisConnectionManager manager) : IInterceptor
{
    private readonly IDatabase _redis = manager.Database; // Ensure this is properly initialized elsewhere

    private static string GenerateCacheKey(MethodInfo method, object[] args)
    {
        var argsKey = string.Join(",", args.Select(a => a.ToString() ?? "null"));
        return $"{method.DeclaringType?.FullName}.{method.Name}({argsKey})";
    }

    private Type GetReturnType(IInvocation invocation)
    {
        if (typeof(Task).IsAssignableFrom(invocation.Method.ReturnType) && invocation.Method.ReturnType.IsGenericType)
        {
            return invocation.Method.ReturnType.GetGenericArguments().First(); // Extract T from Task<T>
        }
        return invocation.Method.ReturnType;
    }

    private MethodType GetDelegateType(IInvocation invocation)
    {
        var returnType = invocation.Method.ReturnType;
        if (returnType == typeof(Task))
        {
            return MethodType.AsyncAction;
        }

        if (returnType.IsGenericType && returnType.GetGenericTypeDefinition() == typeof(Task<>))
        {
            return MethodType.AsyncFunction;
        }

        return MethodType.Synchronous;
    }
    
    private static readonly MethodInfo? HandleAsyncMethodInfo = typeof(RedisCacheInterceptor).GetMethod("HandleAsyncWithResult", BindingFlags.Instance | BindingFlags.NonPublic);
    
    private async Task HandleAsync(Task task)
    {
        await task;
    }

    // ReSharper disable once UnusedMember.Local
    private async Task<T> HandleAsyncWithResult<T>(Task<T> task)
    {
        return await task;
    }
    
    public void Intercept(IInvocation invocation)
    {
        var cacheAttribute = invocation.Method.GetCustomAttributes(typeof(RedisCacheAttribute), true)
            .FirstOrDefault() as RedisCacheAttribute;

        if (cacheAttribute == null)
        {
            // Proceed normally if no attribute is present
            invocation.Proceed();
            return;
        }

        var cacheKey = string.IsNullOrEmpty(cacheAttribute.Key) ? GenerateCacheKey(invocation.Method, invocation.Arguments) : cacheAttribute.Key;
        var cachedValue = _redis.StringGet(cacheKey);

        if (cachedValue.HasValue)
        {
            // Deserialize and return the cached value
            var returnType = GetReturnType(invocation);
            SetReturnValue(invocation, cachedValue, returnType);
            logger.LogDebug("[CACHE HIT] {0}", cacheKey);
            return;
        }

        var delegateType = GetDelegateType(invocation);
        switch (delegateType)
        {
            case MethodType.Synchronous: 
                HandleSyncMethod(invocation, cacheKey, cacheAttribute.DurationSeconds);
                break;
            case MethodType.AsyncAction:
                invocation.Proceed();
                invocation.ReturnValue = HandleAsync((Task)invocation.ReturnValue);
                break;
            case MethodType.AsyncFunction:
                HandleAsyncMethod(invocation, cacheKey, cacheAttribute.DurationSeconds).Wait();
                break;
            default:
                invocation.Proceed();
                break;
        }
    }
    
    private static void SetReturnValue(IInvocation invocation, RedisValue cachedValue, Type returnType)
    {
        // Deserialize using the provided returnType
        var value = BinaryFormatterUtils.DeserializeFromBinary(cachedValue!, returnType);

        if (typeof(Task).IsAssignableFrom(invocation.Method.ReturnType))
        {
            // Create a Task<T> for cached async results
            var taskFromResultMethod = typeof(Task).GetMethod("FromResult")?.MakeGenericMethod(returnType);
            invocation.ReturnValue = taskFromResultMethod?.Invoke(null, new[] { value });
        }
        else
        {
            // For synchronous methods, directly set the return value
            invocation.ReturnValue = value;
        }
    }

    

    private void HandleSyncMethod(IInvocation invocation, string cacheKey, int expirationSeconds)
    {
        // Proceed with the original method call
        invocation.Proceed();

        // Serialize and cache the result
        var serializedValue = BinaryFormatterUtils.SerializeToBinary(invocation.ReturnValue);
        _redis.StringSet(cacheKey, serializedValue, TimeSpan.FromSeconds(expirationSeconds));
        logger.LogDebug("[CACHE SET] {0}", cacheKey);
    }

    private async Task<object?> HandleAsyncMethod(IInvocation invocation, string cacheKey, int expirationSeconds)
    {
        // Proceed with the original async method call
        invocation.Proceed();

        var resultType = invocation.Method.ReturnType.GetGenericArguments()[0];
        var mi = HandleAsyncMethodInfo?.MakeGenericMethod(resultType);
        var value = mi?.Invoke(this, new[] { invocation.ReturnValue });

        if (value != null)
        {
            var task = (Task)value;
            
            await task.ConfigureAwait(false);

            var resultProperty = task.GetType().GetProperty("Result");
            var taskValue = resultProperty?.GetValue(task);

            var serializedValue = BinaryFormatterUtils.SerializeToBinary(taskValue);
            await _redis.StringSetAsync(cacheKey, serializedValue, TimeSpan.FromSeconds(expirationSeconds));

            logger.LogDebug("[CACHE SET] {0}", cacheKey);
            invocation.ReturnValue = value;
        }

        return value;
    }
}