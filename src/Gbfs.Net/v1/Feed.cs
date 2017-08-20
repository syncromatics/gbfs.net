using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// A feed published by this auto-discovery file
    /// </summary>
    [Description("A feed published by this auto-discovery file")]
    public class Feed
    {
        /// <summary>
        /// Key identifying the type of feed this is. (e.g. "system_information", "station_information")
        /// </summary>
        [Description("Key identifying the type of feed this is. (e.g. \"system_information\", \"station_information\")")]
        [JsonProperty(Required = Required.Always)]
        public FeedName Name { get; set; }

        /// <summary>
        /// Full URL for the feed.
        /// </summary>
        [Description("Full URL for the feed.")]
        [JsonProperty(Required = Required.Always)]
        [Url]
        public string Url { get; set; }
    }
}