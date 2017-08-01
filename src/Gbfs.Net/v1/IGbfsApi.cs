using System.Threading.Tasks;
using RestEase;

namespace Gbfs.Net.v1
{

    public interface IGbfsApi
    {
        [Get]
        Task<Manifest> GetManifest();

        [Get("{url}")]
        Task<SystemInformation> GetSystemInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationInformation> GetStationInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationStatus> GetStationStatus([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<FreeBikeStatus> GetFreeBikeStatus([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemHours> GetSystemHours([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemCalendar> GetSystemCalendar([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemRegions> GetSystemRegions([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemPricingPlans> GetSystemPricingPlans([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemAlerts> GetSystemAlerts([Path(UrlEncode = false)] string url);
    }
}
