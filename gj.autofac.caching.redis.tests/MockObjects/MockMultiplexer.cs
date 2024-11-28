using System.Net;
using StackExchange.Redis;
using StackExchange.Redis.Maintenance;
using StackExchange.Redis.Profiling;

namespace gj.autofac.caching.redis.tests.MockObjects;

public class MockMultiplexer: IConnectionMultiplexer
{
    private readonly MockDatabase _database;

    public MockMultiplexer()
    {
        _database = new MockDatabase(this);
    }
    
    public void Dispose()
    {
        _database.Dispose();
    }

    public async ValueTask DisposeAsync()
    {
        throw new NotImplementedException();
    }

    public void RegisterProfiler(Func<ProfilingSession?> profilingSessionProvider)
    {
        throw new NotImplementedException();
    }

    public ServerCounters GetCounters()
    {
        throw new NotImplementedException();
    }

    public EndPoint[] GetEndPoints(bool configuredOnly = false)
    {
        throw new NotImplementedException();
    }

    public void Wait(Task task)
    {
        throw new NotImplementedException();
    }

    public T Wait<T>(Task<T> task)
    {
        throw new NotImplementedException();
    }

    public void WaitAll(params Task[] tasks)
    {
        throw new NotImplementedException();
    }

    public int HashSlot(RedisKey key)
    {
        throw new NotImplementedException();
    }

    public ISubscriber GetSubscriber(object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IDatabase GetDatabase(int db = -1, object? asyncState = null)
    {
        return _database;
    }

    public IServer GetServer(string host, int port, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(string hostAndPort, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(IPAddress host, int port)
    {
        throw new NotImplementedException();
    }

    public IServer GetServer(EndPoint endpoint, object? asyncState = null)
    {
        throw new NotImplementedException();
    }

    public IServer[] GetServers()
    {
        throw new NotImplementedException();
    }

    public async Task<bool> ConfigureAsync(TextWriter? log = null)
    {
        throw new NotImplementedException();
    }

    public bool Configure(TextWriter? log = null)
    {
        throw new NotImplementedException();
    }

    public string GetStatus()
    {
        return "OK";
    }

    public void GetStatus(TextWriter log)
    {
        log.WriteLine("OK");
    }

    public void Close(bool allowCommandsToComplete = true)
    {
        throw new NotImplementedException();
    }

    public async Task CloseAsync(bool allowCommandsToComplete = true)
    {
        throw new NotImplementedException();
    }

    public string? GetStormLog()
    {
        throw new NotImplementedException();
    }

    public void ResetStormLog()
    {
        throw new NotImplementedException();
    }

    public long PublishReconfigure(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public async Task<long> PublishReconfigureAsync(CommandFlags flags = CommandFlags.None)
    {
        throw new NotImplementedException();
    }

    public int GetHashSlot(RedisKey key)
    {
        throw new NotImplementedException();
    }

    public void ExportConfiguration(Stream destination, ExportOptions options = ExportOptions.All)
    {
        throw new NotImplementedException();
    }

    public void AddLibraryNameSuffix(string suffix)
    {
        throw new NotImplementedException();
    }

    public string ClientName { get; }
    public string Configuration { get; }
    public int TimeoutMilliseconds { get; }
    public long OperationCount { get; }
    public bool PreserveAsyncOrder { get; set; }
    public bool IsConnected { get; }
    public bool IsConnecting { get; }
    public bool IncludeDetailInExceptions { get; set; }
    public int StormLogThreshold { get; set; }
    public event EventHandler<RedisErrorEventArgs>? ErrorMessage;
    public event EventHandler<ConnectionFailedEventArgs>? ConnectionFailed;
    public event EventHandler<InternalErrorEventArgs>? InternalError;
    public event EventHandler<ConnectionFailedEventArgs>? ConnectionRestored;
    public event EventHandler<EndPointEventArgs>? ConfigurationChanged;
    public event EventHandler<EndPointEventArgs>? ConfigurationChangedBroadcast;
    public event EventHandler<ServerMaintenanceEvent>? ServerMaintenanceEvent;
    public event EventHandler<HashSlotMovedEventArgs>? HashSlotMoved;
}