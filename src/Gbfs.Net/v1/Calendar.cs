using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Year object describing the system operational calendar.
    /// </summary>
    public class Calendar
    {
        /// <summary>
        /// Starting month for the system operations (1-12)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public byte StartMonth { get; set; }

        /// <summary>
        /// Starting day for the system operations (1-31)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public byte StartDay { get; set; }

        /// <summary>
        /// Starting year for the system operations
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public ushort? StartYear { get; set; }

        /// <summary>
        /// Ending month for the system operations (1-12)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public byte EndMonth { get; set; }

        /// <summary>
        /// Ending day for the system operations (1-31)
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public byte EndDay { get; set; }

        /// <summary>
        /// Ending year for the system operations
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public ushort? EndYear { get; set; }

    }
}