using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// A region object.
    /// </summary>
    public class Region
    {

        /// <summary>
        /// Unique identifier for the region
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string RegionId { get; set; }

        /// <summary>
        /// Public name for this region
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
    }
}