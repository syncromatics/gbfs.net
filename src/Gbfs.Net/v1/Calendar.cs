using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Year object describing the system operational calendar.
    /// </summary>
    [Description("Year object describing the system operational calendar.")]
    public class Calendar
    {
        /// <summary>
        /// Starting month for the system operations (1-12)
        /// </summary>
        [Description("Starting month for the system operations (1-12)")]
        [JsonProperty(Required = Required.Always)]
        [Range(1, 12)]
        public byte StartMonth { get; set; }

        /// <summary>
        /// Starting day for the system operations (1-31)
        /// </summary>
        [Description("Starting day for the system operations (1-31)")]
        [JsonProperty(Required = Required.Always)]
        [Range(1, 31)]
        public byte StartDay { get; set; }

        /// <summary>
        /// Starting year for the system operations
        /// </summary>
        [Description("Starting year for the system operations")]
        [JsonProperty(Required = Required.DisallowNull)]
        public ushort? StartYear { get; set; }

        /// <summary>
        /// Ending month for the system operations (1-12)
        /// </summary>
        [Description("Ending month for the system operations (1-12)")]
        [JsonProperty(Required = Required.Always)]
        [Range(1, 12)]
        public byte EndMonth { get; set; }

        /// <summary>
        /// Ending day for the system operations (1-31)
        /// </summary>
        [Description("Ending day for the system operations (1-31)")]
        [JsonProperty(Required = Required.Always)]
        [Range(1, 31)]
        public byte EndDay { get; set; }

        /// <summary>
        /// Ending year for the system operations
        /// </summary>
        [Description("Ending year for the system operations")]
        [JsonProperty(Required = Required.DisallowNull)]
        public ushort? EndYear { get; set; }

    }
}