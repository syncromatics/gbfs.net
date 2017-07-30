using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describe regions for a system that is broken up by geographic or political region. It is defined as a separate feed to allow for additional region metadata (such as shape definitions).
    /// </summary>
    public class SystemRegionsData
    {
        /// <summary>
        /// Array of region objects
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public List<Region> Regions { get; set; } = new List<Region>();
    }
}