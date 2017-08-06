using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// All stations contained in this list are considered public (ie, can be shown on a map for public use).
    /// </summary>
    /// <remarks>
    /// If there are private stations (such as Capital Bikeshare’s White House station) these should not be exposed here and their status should not be included in station_status.json.
    /// </remarks>
    [Description("All stations contained in this list are considered public (ie, can be shown on a map for public use).")]
    public class StationInformationData
    {
        /// <summary>
        /// Array that contains one object per station in the system
        /// </summary>
        [Description("Array that contains one object per station in the system")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(0)]
        public List<Station> Stations { get; set; } = new List<Station>();
    }
}