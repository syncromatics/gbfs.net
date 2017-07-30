using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes bikes that are not at a station and are not currently in the middle of an active ride.
    /// </summary>
    public class FreeBikeStatusData
    {
        /// <summary>
        /// Array that contains one object per bike that is currently docked/stopped outside of the system.
        /// </summary>
        public List<Bike> Bikes { get; set; }
    }
}