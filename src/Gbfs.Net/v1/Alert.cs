using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// An alert object indicating a system alert
    /// </summary>
    [Description("An alert object indicating a system alert")]
    public class Alert
    {
        /// <summary>
        /// ID - unique identifier for this alert
        /// </summary>
        [Description("ID - unique identifier for this alert")]
        [JsonProperty(Required = Required.Always)]
        public string AlertId { get; set; }

        /// <summary>
        /// Type of alert
        /// </summary>
        [Description("Type of alert")]
        [JsonProperty(Required = Required.Always)]
        public AlertType Type { get; set; }

        /// <summary>
        /// Array of alert times indicating when the alert is in effect (e.g. when the system or station is actually closed, or when it is scheduled to be moved). If this array is omitted then the alert should be displayed as long as it is in the feed.
        /// </summary>
        [Description("Array of alert times indicating when the alert is in effect (e.g. when the system or station is actually closed, or when it is scheduled to be moved). If this array is omitted then the alert should be displayed as long as it is in the feed.")]
        [JsonProperty(Required = Required.DisallowNull)]
        [MinLength(0)]
        public List<AlertTime> Times { get; set; } = new List<AlertTime>();

        /// <summary>
        /// If this is an alert that affects one or more stations, include their ids, otherwise omit this field. If both <see cref="StationIds" /> and <see cref="RegionIds"/> are omitted, assume this alert affects the entire system
        /// </summary>
        [Description("If this is an alert that affects one or more stations, include their ids, otherwise omit this field. If both station_ids and region_ids are omitted, assume this alert affects the entire system")]
        [JsonProperty(Required = Required.DisallowNull)]
        [MinLength(0)]
        public List<string> StationIds { get; set; } = new List<string>();

        /// <summary>
        /// If this system has regions, and if this alert only affects certain regions, include their ids, otherwise, omit this field. If both <see cref="StationIds" /> and <see cref="RegionIds"/> are omitted, assume this alert affects the entire system
        /// </summary>
        [Description("If this system has regions, and if this alert only affects certain regions, include their ids, otherwise, omit this field. If both station_ids and region_ids are omitted, assume this alert affects the entire system")]
        [JsonProperty(Required = Required.DisallowNull)]
        [MinLength(0)]
        public List<string> RegionIds { get; set; } = new List<string>();

        /// <summary>
        /// URL where the customer can learn more information about this alert, if there is one
        /// </summary>
        [JsonProperty(Required = Required.DisallowNull)]
        [Description("URL where the customer can learn more information about this alert, if there is one")]
        [Url]
        public string Url { get; set; }

        /// <summary>
        /// A short summary of this alert to be displayed to the customer
        /// </summary>
        [Description("A short summary of this alert to be displayed to the customer")]
        [JsonProperty(Required = Required.Always)]
        public string Summary { get; set; }

        /// <summary>
        /// Detailed text description of the alert
        /// </summary>
        [Description("Detailed text description of the alert")]
        [JsonProperty(Required = Required.DisallowNull)]
        public string Description { get; set; }

        /// <summary>
        /// Integer POSIX timestamp indicating the last time the info for the particular alert was updated
        /// </summary>
        [Description("Integer POSIX timestamp indicating the last time the info for the particular alert was updated")]
        [JsonProperty(Required = Required.DisallowNull)]
        public long? LastUpdated { get; set; }
    }
}