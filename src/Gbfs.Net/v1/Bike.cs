using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// A bike that is currently docked/stopped outside of the system
    /// </summary>
    [Description("A bike that is currently docked/stopped outside of the system")]
    public class Bike
    {
        /// <summary>
        /// Unique identifier of a bike.
        /// </summary>
        [Description("Unique identifier of a bike.")]
        [JsonProperty(Required = Required.Always)]
        public string BikeId { get; set; }

        /// <summary>
        /// Latitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.
        /// </summary>
        [Description("Latitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.")]
        [JsonProperty(Required = Required.Always)]
        [Range(-90.0, 90.0)]
        public double Lat { get; set; }

        /// <summary>
        /// Longitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.
        /// </summary>
        [Description("Longitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.")]
        [JsonProperty(Required = Required.Always)]
        [Range(-180.0, 180.0)]
        public double Lon { get; set; }

        /// <summary>
        /// Is the bike currently reserved for someone else.
        /// </summary>
        [JsonIgnore]
        public bool IsReserved
        {
            get { return _isReserved != 0; }
            set { _isReserved = value ? 1 : 0; }
        }

        [Description("Is the bike currently reserved for someone else.")]
        [JsonProperty("is_reserved", Required = Required.Always)]
        [Range(0, 1)]
        private int _isReserved { get; set; }

        /// <summary>
        /// Is the bike currently disabled (broken).
        /// </summary>
        [JsonIgnore]
        public bool IsDisabled
        {
            get { return _isDisabled != 0; }
            set { _isDisabled = value ? 1 : 0; }
        }

        [Description("Is the bike currently disabled (broken).")]
        [JsonProperty("is_disabled", Required = Required.Always)]
        [Range(0, 1)]
        private int _isDisabled { get; set; }
    }
}