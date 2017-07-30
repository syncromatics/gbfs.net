using System.Collections.Generic;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <sumamry>
    /// All stations contained in this list are considered public (ie, can be shown on a map for public use).
    /// </summary>
    /// <remarks>
    /// If there are private stations (such as Capital Bikeshare’s White House station) these should not be exposed here and their status should not be included in station_status.json.
    /// </remarks>
    public class StationInformationData
    {
        /// <summary>
        /// Array that contains one object per station in the system
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public List<Station> Stations { get; set; } = new List<Station>();
    }
}