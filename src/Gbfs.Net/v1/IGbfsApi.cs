using System.Threading.Tasks;
using RestEase;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// RESTful API for interacting with GBFS feeds
    /// </summary>
    public interface IGbfsApi
    {
        /// <summary>
        /// Gets the GBFS auto-discovery manifest (<c>gbfs.json</c>)
        /// </summary>
        [Get]
        Task<Manifest> GetManifest();

        /// <summary>
        /// Gets system information file (<c>system_information.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemInformation> GetSystemInformation([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets station information file (<c>station_information.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<StationInformation> GetStationInformation([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets station status file (<c>station_status.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<StationStatus> GetStationStatus([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets free bike status file (<c>free_bike_status.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<FreeBikeStatus> GetFreeBikeStatus([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets system hours file (<c>system_hours.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemHours> GetSystemHours([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets system calendar file (<c>system_calendar.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemCalendar> GetSystemCalendar([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets system regions file (<c>system_regions.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemRegions> GetSystemRegions([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets system pricing plans file (<c>system_pricing_plans.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemPricingPlans> GetSystemPricingPlans([Path(UrlEncode = false)] string url);

        /// <summary>
        /// Gets system alerts file (<c>system_alerts.json</c>)
        /// </summary>
        [Get("{url}")]
        Task<SystemAlerts> GetSystemAlerts([Path(UrlEncode = false)] string url);
    }
}
