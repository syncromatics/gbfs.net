using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbfs.Net
{
    public static class ManifestResponseExtensions
    {
        public static Feed GetFeed(ManifestResponse manifest, IGbfsApi api, string language, string name)
        {
            if (manifest == null) throw new ArgumentNullException(nameof(manifest));
            if (api == null) throw new ArgumentNullException(nameof(api));
            if (string.IsNullOrEmpty(language)) throw new ArgumentOutOfRangeException(nameof(language));

            if (!manifest.Data.TryGetValue(language, out var feeds)) throw new ArgumentOutOfRangeException(nameof(language), $"Feeds not found for language {language}");
            var feed = feeds.Feeds.SingleOrDefault(f => f.Name == name);
            if (feed == null) throw new Exception($"{name} feed not found in manifest for language {language}");

            return feed;
        }

        public static Task<SystemInformationResponse> GetSystemInformation(this ManifestResponse manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "system_information");

            return api.GetSystemInformation(feed.Url);
        }

        public static Task<StationInformationResponse> GetStationInformation(this ManifestResponse manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_information");

            return api.GetStationInformation(feed.Url);
        }

        public static Task<StationStatusResponse> GetStationStatus(this ManifestResponse manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_status");

            return api.GetStationStatus(feed.Url);
        }
    }
}