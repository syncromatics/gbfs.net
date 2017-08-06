using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes bikes that are not at a station and are not currently in the middle of an active ride.
    /// </summary>
    [Description("Describes bikes that are not at a station and are not currently in the middle of an active ride.")]
    public class FreeBikeStatusData
    {
        /// <summary>
        /// Array that contains one object per bike that is currently docked/stopped outside of the system.
        /// </summary>
        [Description("Array that contains one object per bike that is currently docked/stopped outside of the system.")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(0)]
        public List<Bike> Bikes { get; set; } = new List<Bike>();
    }
}