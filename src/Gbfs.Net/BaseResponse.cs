using System;
using Newtonsoft.Json;

namespace Gbfs.Net
{
    public abstract class BaseResponse<T>
        where T : new()
    {
        [JsonProperty("last_updated")]
        public long LastUpdatedSeconds { get; set; }

        [JsonIgnore]
        public DateTimeOffset LastUpdated => DateTimeOffset.FromUnixTimeSeconds(LastUpdatedSeconds);

        [JsonProperty("ttl")]
        public long TimeToLiveSeconds { get; set; }

        public TimeSpan TimeToLive => TimeSpan.FromSeconds(TimeToLiveSeconds);

        public T Data { get; set; } = new T();
    }
}
