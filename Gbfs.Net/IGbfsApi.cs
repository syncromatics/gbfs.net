using System.Threading.Tasks;
using RestEase;

namespace Gbfs.Net
{
    public interface IGbfsApi
    {
        [Get]
        Task<ManifestResponse> GetManifest();

        [Get("{url}")]
        Task<SystemInformationResponse> GetSystemInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationInformationResponse> GetStationInformation([Path(UrlEncode = false)] string url);

        [Get("{url}")]
        Task<StationStatusResponse> GetStationStatus([Path(UrlEncode = false)] string url);
    }
}
