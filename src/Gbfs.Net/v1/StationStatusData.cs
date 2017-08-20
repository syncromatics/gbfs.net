using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Object containing the data fields for the station status response
    /// </summary>
    [Description("Object containing the data fields for the station status response")]
    public class StationStatusData
    {
        /// <summary>
        /// Array that contains one object per station in the system
        /// </summary>
        [Description("Array that contains one object per station in the system")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(0)]
        public List<Status> Stations { get; set; } = new List<Status>();
    }
}