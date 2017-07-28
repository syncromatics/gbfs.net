using System.Threading.Tasks;
using RestEase;

namespace Gbfs.Net
{
    public interface IGbfsApi
    {
        [Get("{url}")]
        Task<ManifestResponse> GetManifest([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<SystemInformationResponse> GetSystemInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationInformationResponse> GetStationInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationStatusResponse> GetStationStatus([Path(UrlEncode = false)] string url);
    }
}
