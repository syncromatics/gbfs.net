using System.Runtime.Serialization;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// This specification defines the following files along with their associated content
    /// </summary>
    public enum FeedName
    {
        /// <summary>
        /// Auto-discovery file that links to all of the other files published by the system. This file is optional, but highly recommended.
        /// </summary>
        [EnumMember(Value = "gbfs")]
        Gbfs,

        /// <summary>
        /// Describes the system including System operator, System location, year implemented, URLs, contact info, time zone
        /// </summary>
        [EnumMember(Value = "system_information")]
        SystemInformation,

        /// <summary>
        /// Mostly static list of all stations, their capacities and locations
        /// </summary>
        [EnumMember(Value = "station_information")]
        StationInformation,

        /// <summary>
        /// Number of available bikes and docks at each station and station availability
        /// </summary>
        [EnumMember(Value = "station_status")]
        StationStatus,

        /// <summary>
        /// Describes bikes that are available in non station-based systems
        /// </summary>
        [EnumMember(Value = "free_bike_status")]
        FreeBikeStatus,

        /// <summary>
        /// Describes the hours of operation for the system
        /// </summary>
        [EnumMember(Value = "system_hours")]
        SystemHours,

        /// <summary>
        /// Describes the days of operation for the system
        /// </summary>
        [EnumMember(Value = "system_calendar")]
        SystemCalendar,

        /// <summary>
        /// Describes the regions the system is broken up into
        /// </summary>
        [EnumMember(Value = "system_regions")]
        SystemRegions,

        /// <summary>
        /// Describes the system pricing
        /// </summary>
        [EnumMember(Value = "system_pricing_plans")]
        SystemPricingPlans,

        /// <summary>
        /// Describes current system alerts
        /// </summary>
        [EnumMember(Value = "system_alerts")]
        SystemAlerts,

    }
}