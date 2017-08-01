using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbfs.Net.v1
{
    public static class ManifestResponseExtensions
    {
        public static Feed GetFeed(Manifest manifest, IGbfsApi api, string language, string name)
        {
            if (manifest == null) throw new ArgumentNullException(nameof(manifest));
            if (api == null) throw new ArgumentNullException(nameof(api));
            if (string.IsNullOrEmpty(language)) throw new ArgumentOutOfRangeException(nameof(language));

            if (!manifest.Data.TryGetValue(language, out var feeds)) throw new ArgumentOutOfRangeException(nameof(language), $"Feeds not found for language {language}");
            var feed = feeds.Feeds.SingleOrDefault(f => f.Name == name);
            if (feed == null) throw new Exception($"{name} feed not found in manifest for language {language}");

            return feed;
        }

        public static Task<SystemInformation> GetSystemInformation(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "system_information");

            return api.GetSystemInformation(feed.Url);
        }

        public static Task<StationInformation> GetStationInformation(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_information");

            return api.GetStationInformation(feed.Url);
        }

        public static Task<StationStatus> GetStationStatus(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_status");

            return api.GetStationStatus(feed.Url);
        }

        public static Task<FreeBikeStatus> GetFreeBikeStatus(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "free_bike_status");

            return api.GetFreeBikeStatus(feed.Url);
        }

        public static Task<SystemHours> GetSystemHours(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_hours");

            return api.GetSystemHours(feed.Url);
        }

        public static Task<SystemCalendar> GetSystemCalendar(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_calendar");

            return api.GetSystemCalendar(feed.Url);
        }

        public static Task<SystemRegions> GetSystemRegions(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_regions");

            return api.GetSystemRegions(feed.Url);
        }

        public static Task<SystemPricingPlans> GetSystemPricingPlans(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_pricing_plans");

            return api.GetSystemPricingPlans(feed.Url);
        }

        public static Task<SystemAlerts> GetSystemAlerts(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_alerts");

            return api.GetSystemAlerts(feed.Url);
        }

    }
}