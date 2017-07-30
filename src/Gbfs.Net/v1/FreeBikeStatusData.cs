using System.Collections.Generic;
using Newtonsoft.Json;

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
        [JsonProperty(Required = Required.Always)]
        public List<Bike> Bikes { get; set; } = new List<Bike>();
    }
}