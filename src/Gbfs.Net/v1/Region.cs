using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// A region object.
    /// </summary>
    [Description("A region object.")]
    public class Region
    {

        /// <summary>
        /// Unique identifier for the region
        /// </summary>
        [Description("Unique identifier for the region")]
        [JsonProperty(Required = Required.Always)]
        public string RegionId { get; set; }

        /// <summary>
        /// Public name for this region
        /// </summary>
        [Description("Public name for this region")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }
    }
}