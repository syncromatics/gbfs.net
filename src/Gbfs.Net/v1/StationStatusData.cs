using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    public class StationStatusData
    {
        /// <summary>
        /// Array that contains one object per station in the system
        /// </summary>
        public List<Status> Stations { get; set; }
    }
}