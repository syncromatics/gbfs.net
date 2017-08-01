using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Object containing the data fields for the station status response
    /// </summary>
    public class StationStatusData
    {
        /// <summary>
        /// Array that contains one object per station in the system
        /// </summary>
        public List<Status> Stations { get; set; } = new List<Status>();
    }
}