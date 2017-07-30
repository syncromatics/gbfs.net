namespace Gbfs.Net.v1
{
    /// <summary>
    /// A bike that is currently docked/stopped outside of the system
    /// </summary>
    public class Bike
    {
        /// <summary>
        /// Unique identifier of a bike.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string BikeId { get; set; }

        /// <summary>
        /// Latitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public double Lat { get; set; }

        /// <summary>
        /// Longitude of the bike. The field value must be a valid WGS 84 latitude in decimal degrees format. See: http://en.wikipedia.org/wiki/World_Geodetic_System, https://en.wikipedia.org/wiki/Decimal_degrees.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public double Lon { get; set; }

        /// <summary>
        /// Is the bike currently reserved for someone else.
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string IsReserved { get; set; }

        /// <summary>
        /// Is the bike currently disabled (broken).
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string IsDisabled { get; set; }
    }
}