using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describe regions for a system that is broken up by geographic or political region. It is defined as a separate feed to allow for additional region metadata (such as shape definitions).
    /// </summary>
    [Description("Describe regions for a system that is broken up by geographic or political region. It is defined as a separate feed to allow for additional region metadata (such as shape definitions).")]
    public class SystemRegionsData
    {
        /// <summary>
        /// Array of region objects
        /// </summary>
        [Description("Array of region objects")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(0)]
        public List<Region> Regions { get; set; } = new List<Region>();
    }
}