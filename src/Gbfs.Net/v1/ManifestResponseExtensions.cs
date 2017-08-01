using System;
using System.Linq;
using System.Threading.Tasks;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Extensions to make working with a <see cref="Manifest" /> easier
    /// </summary>
    public static class ManifestResponseExtensions
    {
        /// <summary>
        /// Gets a feed from the <paramref ref="manifest" /> for the given <paramref ref="language" />
        /// </summary>
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

        /// <summary>
        /// Gets system information feed (<c>system_information</c>)
        /// </summary>
        public static Task<SystemInformation> GetSystemInformation(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "system_information");

            return api.GetSystemInformation(feed.Url);
        }

        /// <summary>
        /// Gets station information feed (<c>station_information</c>)
        /// </summary>
        public static Task<StationInformation> GetStationInformation(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_information");

            return api.GetStationInformation(feed.Url);
        }

        /// <summary>
        /// Gets station status feed (<c>station_status</c>)
        /// </summary>
        public static Task<StationStatus> GetStationStatus(this Manifest manifest, IGbfsApi api, string language)
        {
            var feed = GetFeed(manifest, api, language, "station_status");

            return api.GetStationStatus(feed.Url);
        }

        /// <summary>
        /// Gets free bike status feed (<c>free_bike_status</c>)
        /// </summary>
        public static Task<FreeBikeStatus> GetFreeBikeStatus(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "free_bike_status");

            return api.GetFreeBikeStatus(feed.Url);
        }

        /// <summary>
        /// Gets system hours feed (<c>system_hours</c>)
        /// </summary>
        public static Task<SystemHours> GetSystemHours(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_hours");

            return api.GetSystemHours(feed.Url);
        }

        /// <summary>
        /// Gets system calendar feed (<c>system_calendar</c>)
        /// </summary>
        public static Task<SystemCalendar> GetSystemCalendar(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_calendar");

            return api.GetSystemCalendar(feed.Url);
        }

        /// <summary>
        /// Gets system regions feed (<c>system_regions</c>)
        /// </summary>
        public static Task<SystemRegions> GetSystemRegions(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_regions");

            return api.GetSystemRegions(feed.Url);
        }

        /// <summary>
        /// Gets system pricing plans feed (<c>system_pricing_plans</c>)
        /// </summary>
        public static Task<SystemPricingPlans> GetSystemPricingPlans(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_pricing_plans");

            return api.GetSystemPricingPlans(feed.Url);
        }

        /// <summary>
        /// Gets system alerts feed (<c>system_alerts</c>)
        /// </summary>
        public static Task<SystemAlerts> GetSystemAlerts(this Manifest manifest, IGbfsApi api, string langauge)
        {
            var feed = GetFeed(manifest, api, langauge, "system_alerts");

            return api.GetSystemAlerts(feed.Url);
        }

    }
}