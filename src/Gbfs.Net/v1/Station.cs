using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Defines a station
    /// </summary>
    public class Station
    {
        /// <summary>
        /// Unique identifier of a station.
        /// </summary>
        /// <remarks>
        /// This field is required.
        /// </remarks>
        public string StationId { get; set; }

        /// <summary>
        /// Public name of the station
        /// </summary>
        /// <remarks>
        /// This field is required.
        /// </remarks>
        public string Name { get; set; }

        /// <summary>
        /// Short name or other type of identifier, as used by the data publisher
        /// </summary>
        /// <remarks>
        /// This field is not required.
        /// </remarks>
        public string ShortName { get; set; }

        /// <summary>
        /// The latitude of station. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees
        /// </summary>
        /// <remarks>
        /// This field is required.
        /// </remarks>
        public double Lat { get; set; }

        /// <summary>
        /// The longitude of station. The field value must be a valid WGS 84 longitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees
        /// </summary>
        /// <remarks>
        /// This field is required.
        /// </remarks>
        public double Lon { get; set; }

        /// <summary>
        /// Valid street number and name where station is located. This field is intended to be an actual address, not a free form text description (<see cref="CrossStreet" />)
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public string Address { get; set; }

        /// <summary>
        /// Cross street of where the station is located. This field is intended to be a descriptive field for human consumption. In cities, this would be a cross street, but could also be a description of a location in a park, etc.
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public string CrossStreet { get; set; }

        /// <summary>
        /// ID of the region where station is located (<see cref="SystemRegion" />)
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public string RegionId { get; set; }

        /// <summary>
        /// Postal code where station is located
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public string PostCode { get; set; }

        /// <summary>
        /// <para>
        /// Array of enumerables containing the payment methods accepted at this station.
        /// Current valid values (in CAPS) are:
        /// </para>
        /// <list>
        ///   <item>
        ///     <term>KEY</term>
        ///     <description>(i.e. operator issued bike key / fob / card)</description>
        ///   </item>
        ///   <item>
        ///     <term>CREDITCARD</term>
        ///   </item> 
        ///   <item>
        ///     <term>PAYPASS</term>
        ///   </item> 
        ///   <item>
        ///     <term>APPLEPAY</term>
        ///   </item> 
        ///   <item>
        ///     <term>ANDROIDPAY</term>
        ///   </item> 
        ///   <item>
        ///     <term>TRANSITCARD</term>
        ///   </item> 
        ///   <item>
        ///     <term>ACCOUNTNUMBER</term>
        ///   </item> 
        ///   <item>
        ///     <term>PHONE</term>
        ///   </item>
        /// </list>
        /// <para>
        /// This list is intended to be as comprehensive at the time of publication as possible but is subject to change, as defined in File Requirements in the General Bikeshare Feed Specification 
        /// </para>
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public List<string> RentalMethods { get; set; }

        /// <summary>
        /// Number of total docking points installed at this station, both available and unavailable
        /// </summary>
        /// <remarks>
        /// This field is optional.
        /// </remarks>
        public int Capacity { get; set; }
    }
}