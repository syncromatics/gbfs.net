using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the hours of operation for the system.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class SystemHours : GbfsFile<SystemHoursData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public override SystemHoursData Data { get; set; }
    }
}