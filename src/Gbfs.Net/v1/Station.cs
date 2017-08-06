using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Defines a station
    /// </summary>
    [Description("Defines a station")]
    public class Station
    {
        /// <summary>
        /// Unique identifier of a station.
        /// </summary>
        [Description("Unique identifier of a station.")]
        [JsonProperty(Required = Required.Always)]
        public string StationId { get; set; }

        /// <summary>
        /// Public name of the station
        /// </summary>
        [Description("Public name of the station")]
        [JsonProperty(Required = Required.Always)]
        public string Name { get; set; }

        /// <summary>
        /// Short name or other type of identifier, as used by the data publisher
        /// </summary>
        [Description("Short name or other type of identifier, as used by the data publisher")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string ShortName { get; set; }

        /// <summary>
        /// The latitude of station. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees
        /// </summary>
        [Description("The latitude of station. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees")]
        [JsonProperty(Required = Required.Always)]
        [Range(-90.0, 90.0)]
        public double Lat { get; set; }

        /// <summary>
        /// The longitude of station. The field value must be a valid WGS 84 longitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees
        /// </summary>
        [Description("The longitude of station. The field value must be a valid WGS 84 longitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees")]
        [JsonProperty(Required = Required.Always)]
        [Range(-180.0, 180.0)]
        public double Lon { get; set; }

        /// <summary>
        /// Valid street number and name where station is located. This field is intended to be an actual address, not a free form text description (<see cref="CrossStreet" />)
        /// </summary>
        [Description("Valid street number and name where station is located. This field is intended to be an actual address, not a free form text description (see cross_street)")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Address { get; set; }

        /// <summary>
        /// Cross street of where the station is located. This field is intended to be a descriptive field for human consumption. In cities, this would be a cross street, but could also be a description of a location in a park, etc.
        /// </summary>
        [Description("Cross street of where the station is located. This field is intended to be a descriptive field for human consumption. In cities, this would be a cross street, but could also be a description of a location in a park, etc.")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string CrossStreet { get; set; }

        /// <summary>
        /// ID of the region where station is located (<see cref="SystemRegions" />)
        /// </summary>
        [Description("ID of the region where station is located (see system_regions)")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string RegionId { get; set; }

        /// <summary>
        /// Postal code where station is located
        /// </summary>
        [Description("Postal code where station is located")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string PostCode { get; set; }

        /// <summary>
        /// Array of enumerables containing the payment methods accepted at this station.
        /// </summary>
        [Description("Array of enumerables containing the payment methods accepted at this station.")]
        [JsonProperty(Required = Required.DisallowNull)]
        [MinLength(1)]
        public List<RentalMethodType> RentalMethods { get; set; } = new List<RentalMethodType>();

        /// <summary>
        /// Number of total docking points installed at this station, both available and unavailable
        /// </summary>
        [Description("Number of total docking points installed at this station, both available and unavailable")]
        [JsonProperty(Required = Required.DisallowNull)]
        public int? Capacity { get; set; }
    }
}