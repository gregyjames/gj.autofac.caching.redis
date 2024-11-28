using System.Net;
using System.Runtime.Caching;
using StackExchange.Redis;
using CacheItemPolicy = System.Runtime.Caching.CacheItemPolicy;

namespace gj.autofac.caching.redis.tests.MockObjects
{
    public class MockDatabase : IDatabase, IDisposable
    {
        private readonly MockMultiplexer _mockMultiplexer;
        private readonly MemoryCache _cache;

        public MockDatabase(MockMultiplexer mockMultiplexer)
        {
            _mockMultiplexer = mockMultiplexer;
            _cache = MemoryCache.Default;
        }

        public void WaitAll(params Task[] tasks)
        {
            throw new NotImplementedException();
        }

        public IConnectionMultiplexer Multiplexer => _mockMultiplexer;

        public bool IsConnected(RedisKey key, CommandFlags flags = CommandFlags.None) => true;

        public async Task KeyMigrateAsync(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> DebugObjectAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GeoAddAsync(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GeoAddAsync(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> GeoAddAsync(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> GeoRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double?> GeoDistanceAsync(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<string?[]> GeoHashAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<string?> GeoHashAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoPosition?[]> GeoPositionAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoPosition?> GeoPositionAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoRadiusResult[]> GeoRadiusAsync(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoRadiusResult[]> GeoSearchAsync(RedisKey key, RedisValue member, GeoSearchShape shape, int count = -1, bool demandClosest = true,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<GeoRadiusResult[]> GeoSearchAsync(RedisKey key, double longitude, double latitude, GeoSearchShape shape, int count = -1,
            bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> GeoSearchAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, RedisValue member, GeoSearchShape shape,
            int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> GeoSearchAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, double longitude, double latitude,
            GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HashDecrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double> HashDecrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HashDeleteAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HashDeleteAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HashExistsAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpireResult[]> HashFieldExpireAsync(RedisKey key, RedisValue[] hashFields, TimeSpan expiry, ExpireWhen when = ExpireWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<ExpireResult[]> HashFieldExpireAsync(RedisKey key, RedisValue[] hashFields, DateTime expiry, ExpireWhen when = ExpireWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long[]> HashFieldGetExpireDateTimeAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<PersistResult[]> HashFieldPersistAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long[]> HashFieldGetTimeToLiveAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> HashGetAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<Lease<byte>?> HashGetLeaseAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> HashGetAsync(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<TimeSpan> PingAsync(CommandFlags flags = CommandFlags.None)
        {
            return await Task.FromResult(TimeSpan.Zero);
        }

        public bool TryWait(Task task)
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

        public TimeSpan Ping(CommandFlags flags = CommandFlags.None)
        {
            return TimeSpan.Zero;
        }

        // String Commands
        public async Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(true);
        }

        public async Task<double> StringDecrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            var result = _cache.Get(key.ToString());
            return await Task.FromResult(result != null ? (RedisValue)result : RedisValue.Null);
        }

        public async Task<RedisValue[]> StringGetAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<Lease<byte>?> StringGetLeaseAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StringGetBitAsync(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetRangeAsync(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetSetAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetSetExpiryAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetSetExpiryAsync(RedisKey key, DateTime expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StringGetDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValueWithExpiry> StringGetWithExpiryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringIncrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            var currentValue = _cache.Get(key.ToString()) as long? ?? 0;
            var newValue = currentValue + value;
            _cache.Set(key.ToString(), newValue, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(newValue);
        }

        public async Task<double> StringIncrementAsync(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            var currentValue = _cache.Get(key.ToString()) as double? ?? 0.0;
            var newValue = currentValue + value;
            _cache.Set(key.ToString(), newValue, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(newValue);
        }

        public async Task<long> StringLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<string?> StringLongestCommonSubsequenceAsync(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringLongestCommonSubsequenceLengthAsync(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<LCSMatchResult> StringLongestCommonSubsequenceWithMatchesAsync(RedisKey first, RedisKey second, long minLength = 0,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(true);
        }

        public async Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(true);
        }

        public async Task<bool> StringSetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always,
            CommandFlags flags = CommandFlags.None)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(true);
        }

        public async Task<bool> StringSetAsync(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            foreach (var value in values)
            {
                _cache.Set(value.Key.ToString(), value.Value, ObjectCache.InfiniteAbsoluteExpiration);
            }
            return await Task.FromResult(true);
        }

        public async Task<RedisValue> StringSetAndGetAsync(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(value);
        }

        public async Task<RedisValue> StringSetAndGetAsync(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false,
            When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return await Task.FromResult(value);
        }

        public async Task<bool> StringSetBitAsync(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            var currentValue = _cache.Get(key.ToString()) as byte[] ?? new byte[1];
            var byteIndex = offset / 8;
            var bitIndex = (int)(offset % 8);

            if (byteIndex >= currentValue.Length)
            {
                Array.Resize(ref currentValue, (int)(byteIndex + 1));
            }

            if (bit)
                currentValue[byteIndex] |= (byte)(1 << bitIndex);
            else
                currentValue[byteIndex] &= (byte)~(1 << bitIndex);

            _cache.Set(key.ToString(), currentValue, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(true);
        }

        public async Task<RedisValue> StringSetRangeAsync(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyCopyAsync(RedisKey sourceKey, RedisKey destinationKey, int destinationDatabase = -1, bool replace = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyDeleteAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            if (_cache.Contains(key.ToString()))
            {
                _cache.Remove(key.ToString());
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }

        public async Task<long> KeyDeleteAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<byte[]?> KeyDumpAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<string?> KeyEncodingAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyExistsAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            return await Task.FromResult(_cache.Contains(key.ToString()));
        }

        public async Task<long> KeyExistsAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            if (_cache.Contains(key.ToString()))
            {
                var policy = new CacheItemPolicy
                {
                    AbsoluteExpiration = expiry.HasValue
                        ? DateTimeOffset.UtcNow.Add(expiry.Value)
                        : ObjectCache.InfiniteAbsoluteExpiration
                };
                var value = _cache.Get(key.ToString());
                _cache.Set(key.ToString(), value, policy);
                return await Task.FromResult(true);
            }

            return await Task.FromResult(false);
        }

        public async Task<bool> KeyExpireAsync(RedisKey key, TimeSpan? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyExpireAsync(RedisKey key, DateTime? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<DateTime?> KeyExpireTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long?> KeyFrequencyAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<TimeSpan?> KeyIdleTimeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyMoveAsync(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyPersistAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisKey> KeyRandomAsync(CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long?> KeyRefCountAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyRenameAsync(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task KeyRestoreAsync(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<TimeSpan?> KeyTimeToLiveAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> KeyTouchAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> KeyTouchAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisType> KeyTypeAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> ListGetByIndexAsync(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListInsertAfterAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListInsertBeforeAsync(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HashIncrementAsync(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            var hash = _cache.Get(key.ToString()) as Dictionary<string, long> ?? new Dictionary<string, long>();
            var fieldKey = hashField.ToString();
            hash[fieldKey] = hash.TryGetValue(fieldKey, out var currentValue) ? currentValue + value : value;
            _cache.Set(key.ToString(), hash, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(hash[fieldKey]);
        }

        public async Task<double> HashIncrementAsync(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> HashKeysAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HashLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> HashRandomFieldAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> HashRandomFieldsAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<HashEntry[]> HashRandomFieldsWithValuesAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<HashEntry> HashScanAsync(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<RedisValue> HashScanNoValuesAsync(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250,
            long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task HashSetAsync(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            var hash = _cache.Get(key.ToString()) as Dictionary<string, RedisValue> ?? new Dictionary<string, RedisValue>();
            foreach (var field in hashFields)
            {
                hash[field.Name] = field.Value;
            }
            _cache.Set(key.ToString(), hash, ObjectCache.InfiniteAbsoluteExpiration);
            await Task.FromResult(true);
        }

        public async Task<bool> HashSetAsync(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HashStringLengthAsync(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> HashValuesAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> HyperLogLogAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HyperLogLogLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> HyperLogLogLengthAsync(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task HyperLogLogMergeAsync(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task HyperLogLogMergeAsync(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<EndPoint?> IdentifyEndpointAsync(RedisKey key = new RedisKey(), CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<HashEntry[]> HashGetAllAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            var hash = _cache.Get(key.ToString()) as Dictionary<string, RedisValue>;
            if (hash == null)
                return Array.Empty<HashEntry>();

            return await Task.FromResult(hash.Select(kv => new HashEntry(kv.Key, kv.Value)).ToArray());
        }

        public async Task<RedisResult> ScriptEvaluateReadOnlyAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetAddAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var set = _cache.Get(key.ToString()) as HashSet<RedisValue> ?? new HashSet<RedisValue>();
            var added = set.Add(value);
            _cache.Set(key.ToString(), set, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(added);
        }

        public async Task<long> SetAddAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SetCombineAsync(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetContainsAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool[]> SetContainsAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SetIntersectionLengthAsync(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SetLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SetMembersAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetMoveAsync(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> SetPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SetPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> SetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SetRemoveAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var set = _cache.Get(key.ToString()) as HashSet<RedisValue>;
            if (set == null)
                return await Task.FromResult(false);

            var removed = set.Remove(value);
            _cache.Set(key.ToString(), set, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(removed);
        }

        public async Task<long> SetRemoveAsync(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<RedisValue> SetScanAsync(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortAsync(RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue by = new RedisValue(), RedisValue[]? get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortAndStoreAsync(RedisKey destination, RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue by = new RedisValue(), RedisValue[]? get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, When when, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SortedSetAddAsync(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, When when, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetAddAsync(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetCombineAsync(SetOperation operation, RedisKey[] keys, double[]? weights = null, Aggregate aggregate = Aggregate.Sum,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry[]> SortedSetCombineWithScoresAsync(SetOperation operation, RedisKey[] keys, double[]? weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetCombineAndStoreAsync(SetOperation operation, RedisKey destination, RedisKey[] keys,
            double[]? weights = null, Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SortedSetDecrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double> SortedSetIncrementAsync(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetIntersectionLengthAsync(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetLengthAsync(RedisKey key, double min = -Infinity, double max = Infinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetLengthByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> SortedSetRandomMemberAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetRandomMembersAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry[]> SortedSetRandomMembersWithScoresAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetRangeByRankAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetRangeAndStoreAsync(RedisKey sourceKey, RedisKey destinationKey, RedisValue start, RedisValue stop,
            SortedSetOrder sortedSetOrder = SortedSetOrder.ByRank, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0,
            long? take = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry[]> SortedSetRangeByRankWithScoresAsync(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetRangeByScoreAsync(RedisKey key, double start = -Infinity, double stop = Infinity, Exclude exclude = Exclude.None,
            Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry[]> SortedSetRangeByScoreWithScoresAsync(RedisKey key, double start = -Infinity, double stop = Infinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> SortedSetRangeByValueAsync(RedisKey key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long?> SortedSetRankAsync(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SortedSetRemoveAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetRemoveAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetRemoveRangeByRankAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetRemoveRangeByScoreAsync(RedisKey key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetRemoveRangeByValueAsync(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IAsyncEnumerable<SortedSetEntry> SortedSetScanAsync(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250,
            long cursor = 0, int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double?> SortedSetScoreAsync(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<double?[]> SortedSetScoresAsync(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> SortedSetUpdateAsync(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> SortedSetUpdateAsync(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry?> SortedSetPopAsync(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetEntry[]> SortedSetPopAsync(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<SortedSetPopResult> SortedSetPopAsync(RedisKey[] keys, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamAcknowledgeAsync(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StreamAddAsync(RedisKey key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> StreamAddAsync(RedisKey key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamAutoClaimResult> StreamAutoClaimAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue startAtId, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamAutoClaimIdsOnlyResult> StreamAutoClaimIdsOnlyAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue startAtId, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamEntry[]> StreamClaimAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> StreamClaimIdsOnlyAsync(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StreamConsumerGroupSetPositionAsync(RedisKey key, RedisValue groupName, RedisValue position,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamConsumerInfo[]> StreamConsumerInfoAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StreamCreateConsumerGroupAsync(RedisKey key, RedisValue groupName, RedisValue? position = null,
            bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamDeleteAsync(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamDeleteConsumerAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> StreamDeleteConsumerGroupAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamGroupInfo[]> StreamGroupInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamInfo> StreamInfoAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamPendingInfo> StreamPendingAsync(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamPendingMessageInfo[]> StreamPendingMessagesAsync(RedisKey key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamEntry[]> StreamRangeAsync(RedisKey key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamEntry[]> StreamReadAsync(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisStream[]> StreamReadAsync(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamEntry[]> StreamReadGroupAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position, int? count,
            CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<StreamEntry[]> StreamReadGroupAsync(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisStream[]> StreamReadGroupAsync(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StreamTrimAsync(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringAppendAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitCountAsync(RedisKey key, long start, long end, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitCountAsync(RedisKey key, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitOperationAsync(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start, long end, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringBitPositionAsync(RedisKey key, bool bit, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> StringDecrementAsync(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListLeftPushAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var list = _cache.Get(key.ToString()) as LinkedList<RedisValue> ?? new LinkedList<RedisValue>();
            list.AddFirst(value);
            _cache.Set(key.ToString(), list, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(list.Count);
        }

        public async Task<long> ListRightPushAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var list = _cache.Get(key.ToString()) as LinkedList<RedisValue> ?? new LinkedList<RedisValue>();
            list.AddLast(value);
            _cache.Set(key.ToString(), list, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(list.Count);
        }

        public async Task<RedisValue> ListLeftPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            var list = _cache.Get(key.ToString()) as LinkedList<RedisValue>;
            if (list == null || list.Count == 0)
                return await Task.FromResult(RedisValue.Null);

            var value = list.First.Value;
            list.RemoveFirst();
            _cache.Set(key.ToString(), list, ObjectCache.InfiniteAbsoluteExpiration);
            return await Task.FromResult(value);
        }

        public async Task<RedisValue[]> ListLeftPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<ListPopResult> ListLeftPopAsync(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListPositionAsync(RedisKey key, RedisValue element, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long[]> ListPositionsAsync(RedisKey key, RedisValue element, long count, long rank = 1, long maxLength = 0,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListLeftPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListLeftPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListLengthAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> ListMoveAsync(RedisKey sourceKey, RedisKey destinationKey, ListSide sourceSide, ListSide destinationSide,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> ListRangeAsync(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListRemoveAsync(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> ListRightPopAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue[]> ListRightPopAsync(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<ListPopResult> ListRightPopAsync(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> ListRightPopLeftPushAsync(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListRightPushAsync(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> ListRightPushAsync(RedisKey key, RedisValue[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public async Task ListSetByIndexAsync(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task ListTrimAsync(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LockExtendAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisValue> LockQueryAsync(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LockReleaseAsync(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> LockTakeAsync(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<long> PublishAsync(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ExecuteAsync(string command, params object[] args)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ExecuteAsync(string command, ICollection<object>? args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ScriptEvaluateAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ScriptEvaluateAsync(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ScriptEvaluateAsync(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ScriptEvaluateAsync(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public async Task<RedisResult> ScriptEvaluateReadOnlyAsync(string script, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IBatch CreateBatch(object? asyncState = null)
        {
            throw new NotImplementedException();
        }

        public ITransaction CreateTransaction(object? asyncState = null)
        {
            throw new NotImplementedException();
        }

        public void KeyMigrate(RedisKey key, EndPoint toServer, int toDatabase = 0, int timeoutMilliseconds = 0,
            MigrateOptions migrateOptions = MigrateOptions.None, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue DebugObject(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool GeoAdd(RedisKey key, double longitude, double latitude, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool GeoAdd(RedisKey key, GeoEntry value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long GeoAdd(RedisKey key, GeoEntry[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool GeoRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double? GeoDistance(RedisKey key, RedisValue member1, RedisValue member2, GeoUnit unit = GeoUnit.Meters,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public string?[] GeoHash(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public string? GeoHash(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoPosition?[] GeoPosition(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoPosition? GeoPosition(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key, RedisValue member, double radius, GeoUnit unit = GeoUnit.Meters, int count = -1,
            Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoRadiusResult[] GeoRadius(RedisKey key, double longitude, double latitude, double radius, GeoUnit unit = GeoUnit.Meters,
            int count = -1, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoRadiusResult[] GeoSearch(RedisKey key, RedisValue member, GeoSearchShape shape, int count = -1,
            bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public GeoRadiusResult[] GeoSearch(RedisKey key, double longitude, double latitude, GeoSearchShape shape, int count = -1,
            bool demandClosest = true, Order? order = null, GeoRadiusOptions options = GeoRadiusOptions.Default, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long GeoSearchAndStore(RedisKey sourceKey, RedisKey destinationKey, RedisValue member, GeoSearchShape shape,
            int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long GeoSearchAndStore(RedisKey sourceKey, RedisKey destinationKey, double longitude, double latitude,
            GeoSearchShape shape, int count = -1, bool demandClosest = true, Order? order = null, bool storeDistances = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HashDecrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double HashDecrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool HashDelete(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HashDelete(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool HashExists(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public ExpireResult[] HashFieldExpire(RedisKey key, RedisValue[] hashFields, TimeSpan expiry, ExpireWhen when = ExpireWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public ExpireResult[] HashFieldExpire(RedisKey key, RedisValue[] hashFields, DateTime expiry, ExpireWhen when = ExpireWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long[] HashFieldGetExpireDateTime(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public PersistResult[] HashFieldPersist(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long[] HashFieldGetTimeToLive(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue HashGet(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public Lease<byte>? HashGetLease(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] HashGet(RedisKey key, RedisValue[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public HashEntry[] HashGetAll(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HashIncrement(RedisKey key, RedisValue hashField, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double HashIncrement(RedisKey key, RedisValue hashField, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] HashKeys(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HashLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue HashRandomField(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] HashRandomFields(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public HashEntry[] HashRandomFieldsWithValues(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<HashEntry> HashScan(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RedisValue> HashScanNoValues(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public void HashSet(RedisKey key, HashEntry[] hashFields, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool HashSet(RedisKey key, RedisValue hashField, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HashStringLength(RedisKey key, RedisValue hashField, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] HashValues(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool HyperLogLogAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HyperLogLogLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long HyperLogLogLength(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public void HyperLogLogMerge(RedisKey destination, RedisKey[] sourceKeys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public EndPoint? IdentifyEndpoint(RedisKey key = new RedisKey(), CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyCopy(RedisKey sourceKey, RedisKey destinationKey, int destinationDatabase = -1, bool replace = false,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long KeyDelete(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public byte[]? KeyDump(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public string? KeyEncoding(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyExists(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long KeyExists(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyExpire(RedisKey key, TimeSpan? expiry, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public bool KeyExpire(RedisKey key, TimeSpan? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyExpire(RedisKey key, DateTime? expiry, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public bool KeyExpire(RedisKey key, DateTime? expiry, ExpireWhen when = ExpireWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public DateTime? KeyExpireTime(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long? KeyFrequency(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public TimeSpan? KeyIdleTime(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyMove(RedisKey key, int database, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyPersist(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisKey KeyRandom(CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long? KeyRefCount(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyRename(RedisKey key, RedisKey newKey, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public void KeyRestore(RedisKey key, byte[] value, TimeSpan? expiry = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public TimeSpan? KeyTimeToLive(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool KeyTouch(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long KeyTouch(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisType KeyType(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue ListGetByIndex(RedisKey key, long index, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListInsertAfter(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListInsertBefore(RedisKey key, RedisValue pivot, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue ListLeftPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] ListLeftPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public ListPopResult ListLeftPop(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListPosition(RedisKey key, RedisValue element, long rank = 1, long maxLength = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long[] ListPositions(RedisKey key, RedisValue element, long count, long rank = 1, long maxLength = 0,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListLeftPush(RedisKey key, RedisValue[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public long ListLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue ListMove(RedisKey sourceKey, RedisKey destinationKey, ListSide sourceSide, ListSide destinationSide,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] ListRange(RedisKey key, long start = 0, long stop = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListRemove(RedisKey key, RedisValue value, long count = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue ListRightPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] ListRightPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public ListPopResult ListRightPop(RedisKey[] keys, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue ListRightPopLeftPush(RedisKey source, RedisKey destination, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListRightPush(RedisKey key, RedisValue value, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListRightPush(RedisKey key, RedisValue[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long ListRightPush(RedisKey key, RedisValue[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public void ListSetByIndex(RedisKey key, long index, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public void ListTrim(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool LockExtend(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue LockQuery(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool LockRelease(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool LockTake(RedisKey key, RedisValue value, TimeSpan expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long Publish(RedisChannel channel, RedisValue message, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult Execute(string command, params object[] args)
        {
            throw new NotImplementedException();
        }

        public RedisResult Execute(string command, ICollection<object> args, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluate(string script, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluate(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluate(LuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluate(LoadedLuaScript script, object? parameters = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluateReadOnly(string script, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisResult ScriptEvaluateReadOnly(byte[] hash, RedisKey[]? keys = null, RedisValue[]? values = null,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SetAdd(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetAdd(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SetCombine(SetOperation operation, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SetContains(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool[] SetContains(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetIntersectionLength(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SetMembers(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SetMove(RedisKey source, RedisKey destination, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue SetPop(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SetPop(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue SetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SetRemove(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SetRemove(RedisKey key, RedisValue[] values, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RedisValue> SetScan(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] Sort(RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending, SortType sortType = SortType.Numeric,
            RedisValue by = new RedisValue(), RedisValue[]? get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortAndStore(RedisKey destination, RedisKey key, long skip = 0, long take = -1, Order order = Order.Ascending,
            SortType sortType = SortType.Numeric, RedisValue by = new RedisValue(), RedisValue[]? get = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, When when, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SortedSetAdd(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, When when, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetAdd(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetCombine(SetOperation operation, RedisKey[] keys, double[]? weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetEntry[] SortedSetCombineWithScores(SetOperation operation, RedisKey[] keys, double[]? weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey first, RedisKey second,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetCombineAndStore(SetOperation operation, RedisKey destination, RedisKey[] keys, double[]? weights = null,
            Aggregate aggregate = Aggregate.Sum, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double SortedSetDecrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double SortedSetIncrement(RedisKey key, RedisValue member, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetIntersectionLength(RedisKey[] keys, long limit = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetLength(RedisKey key, double min = -Infinity, double max = Infinity, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetLengthByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue SortedSetRandomMember(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetRandomMembers(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetEntry[] SortedSetRandomMembersWithScores(RedisKey key, long count, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetRangeByRank(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetRangeAndStore(RedisKey sourceKey, RedisKey destinationKey, RedisValue start, RedisValue stop,
            SortedSetOrder sortedSetOrder = SortedSetOrder.ByRank, Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0,
            long? take = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetEntry[] SortedSetRangeByRankWithScores(RedisKey key, long start = 0, long stop = -1, Order order = Order.Ascending,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetRangeByScore(RedisKey key, double start = -Infinity, double stop = Infinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        private const int Infinity = int.MaxValue;

        public SortedSetEntry[] SortedSetRangeByScoreWithScores(RedisKey key, double start = -Infinity, double stop = Infinity,
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude, long skip,
            long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] SortedSetRangeByValue(RedisKey key, RedisValue min = new RedisValue(), RedisValue max = new RedisValue(),
            Exclude exclude = Exclude.None, Order order = Order.Ascending, long skip = 0, long take = -1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long? SortedSetRank(RedisKey key, RedisValue member, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SortedSetRemove(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetRemove(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetRemoveRangeByRank(RedisKey key, long start, long stop, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetRemoveRangeByScore(RedisKey key, double start, double stop, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetRemoveRangeByValue(RedisKey key, RedisValue min, RedisValue max, Exclude exclude = Exclude.None,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern, int pageSize, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<SortedSetEntry> SortedSetScan(RedisKey key, RedisValue pattern = new RedisValue(), int pageSize = 250, long cursor = 0,
            int pageOffset = 0, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double? SortedSetScore(RedisKey key, RedisValue member, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double?[] SortedSetScores(RedisKey key, RedisValue[] members, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetEntry? SortedSetPop(RedisKey key, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetEntry[] SortedSetPop(RedisKey key, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public SortedSetPopResult SortedSetPop(RedisKey[] keys, long count, Order order = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool SortedSetUpdate(RedisKey key, RedisValue member, double score, SortedSetWhen when = SortedSetWhen.Always,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long SortedSetUpdate(RedisKey key, SortedSetEntry[] values, SortedSetWhen when = SortedSetWhen.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue messageId, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamAcknowledge(RedisKey key, RedisValue groupName, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StreamAdd(RedisKey key, RedisValue streamField, RedisValue streamValue, RedisValue? messageId = null,
            int? maxLength = null, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StreamAdd(RedisKey key, NameValueEntry[] streamPairs, RedisValue? messageId = null, int? maxLength = null,
            bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamAutoClaimResult StreamAutoClaim(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue startAtId, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamAutoClaimIdsOnlyResult StreamAutoClaimIdsOnly(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue startAtId, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamEntry[] StreamClaim(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer, long minIdleTimeInMs,
            RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue[] StreamClaimIdsOnly(RedisKey key, RedisValue consumerGroup, RedisValue claimingConsumer,
            long minIdleTimeInMs, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool StreamConsumerGroupSetPosition(RedisKey key, RedisValue groupName, RedisValue position, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamConsumerInfo[] StreamConsumerInfo(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public bool StreamCreateConsumerGroup(RedisKey key, RedisValue groupName, RedisValue? position = null,
            bool createStream = true, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamDelete(RedisKey key, RedisValue[] messageIds, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamDeleteConsumer(RedisKey key, RedisValue groupName, RedisValue consumerName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool StreamDeleteConsumerGroup(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamGroupInfo[] StreamGroupInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamInfo StreamInfo(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamPendingInfo StreamPending(RedisKey key, RedisValue groupName, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamPendingMessageInfo[] StreamPendingMessages(RedisKey key, RedisValue groupName, int count, RedisValue consumerName,
            RedisValue? minId = null, RedisValue? maxId = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamEntry[] StreamRange(RedisKey key, RedisValue? minId = null, RedisValue? maxId = null, int? count = null,
            Order messageOrder = Order.Ascending, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamEntry[] StreamRead(RedisKey key, RedisValue position, int? count = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisStream[] StreamRead(StreamPosition[] streamPositions, int? countPerStream = null, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public StreamEntry[] StreamReadGroup(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position,
            int? count, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public StreamEntry[] StreamReadGroup(RedisKey key, RedisValue groupName, RedisValue consumerName, RedisValue? position = null,
            int? count = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public RedisStream[] StreamReadGroup(StreamPosition[] streamPositions, RedisValue groupName, RedisValue consumerName,
            int? countPerStream = null, bool noAck = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StreamTrim(RedisKey key, int maxLength, bool useApproximateMaxLength = false, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringAppend(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringBitCount(RedisKey key, long start, long end, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public long StringBitCount(RedisKey key, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey first, RedisKey second = new RedisKey(),
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringBitOperation(Bitwise operation, RedisKey destination, RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringBitPosition(RedisKey key, bool bit, long start, long end, CommandFlags flags)
        {
            throw new NotImplementedException();
        }

        public long StringBitPosition(RedisKey key, bool bit, long start = 0, long end = -1, StringIndexType indexType = StringIndexType.Byte,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringDecrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double StringDecrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringGet(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            var result = _cache.Get(key.ToString());
            return result != null ? (RedisValue)result : RedisValue.Null;
        }

        public RedisValue[] StringGet(RedisKey[] keys, CommandFlags flags = CommandFlags.None)
        {
            return keys.Select(x =>
            {
                var result = _cache.Get(x.ToString());
                return result != null ? (RedisValue)result : RedisValue.Null;
            }).ToArray();
        }

        public Lease<byte>? StringGetLease(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool StringGetBit(RedisKey key, long offset, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringGetRange(RedisKey key, long start, long end, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringGetSet(RedisKey key, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            var result = _cache.Get(key.ToString());
            return value;

        }

        public RedisValue StringGetSetExpiry(RedisKey key, TimeSpan? expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringGetSetExpiry(RedisKey key, DateTime expiry, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringGetDelete(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValueWithExpiry StringGetWithExpiry(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringIncrement(RedisKey key, long value = 1, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public double StringIncrement(RedisKey key, double value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringLength(RedisKey key, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public string? StringLongestCommonSubsequence(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public long StringLongestCommonSubsequenceLength(RedisKey first, RedisKey second, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public LCSMatchResult StringLongestCommonSubsequenceWithMatches(RedisKey first, RedisKey second, long minLength = 0,
            CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry, When when)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return true;
        }

        public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return true;
        }

        public bool StringSet(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false, When when = When.Always,
            CommandFlags flags = CommandFlags.None)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return true;
        }

        public bool StringSet(KeyValuePair<RedisKey, RedisValue>[] values, When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringSetAndGet(RedisKey key, RedisValue value, TimeSpan? expiry, When when, CommandFlags flags)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return value;
        }

        public RedisValue StringSetAndGet(RedisKey key, RedisValue value, TimeSpan? expiry = null, bool keepTtl = false,
            When when = When.Always, CommandFlags flags = CommandFlags.None)
        {
            var policy = new CacheItemPolicy
            {
                AbsoluteExpiration = expiry.HasValue
                    ? DateTimeOffset.UtcNow.Add(expiry.Value)
                    : ObjectCache.InfiniteAbsoluteExpiration
            };
            _cache.Set(key.ToString(), value, policy);
            return value;
        }

        public bool StringSetBit(RedisKey key, long offset, bool bit, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public RedisValue StringSetRange(RedisKey key, long offset, RedisValue value, CommandFlags flags = CommandFlags.None)
        {
            throw new NotImplementedException();
        }

        public int Database { get; }

        public void Dispose()
        {
            _mockMultiplexer.Dispose();
            _cache.Dispose();
        }
    }
}
