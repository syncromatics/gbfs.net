using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Represents the common format of GBFS data
    /// </summary>
    public abstract class GbfsFile<T> : IGbfsFile<T>
    {
        /// <summary>
        /// Integer POSIX timestamp indicating the last time the data in this feed was updated
        /// </summary>
        [Description("Integer POSIX timestamp indicating the last time the data in this feed was updated")]
        [JsonProperty(Required = Required.Always)]
        public virtual long LastUpdated { get; set; }

        /// <summary>
        /// Integer representing the number of seconds before the data in this feed will be updated again (0 if the data should always be refreshed)
        /// </summary>
        [Description("Integer representing the number of seconds before the data in this feed will be updated again (0 if the data should always be refreshed)")]
        [JsonProperty("ttl", Required = Required.Always)]
        [Range(0.0, double.PositiveInfinity)]
        public virtual long TimeToLive { get; set; }

        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        [JsonProperty(Required = Required.Always)]
        public abstract T Data { get; set; }
    }
}