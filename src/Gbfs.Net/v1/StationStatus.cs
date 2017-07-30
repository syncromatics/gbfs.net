using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Number of available bikes and docks at each station and station availability.
    /// </summary>
    public class StationStatus : GbfsFile<StationStatusData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [JsonProperty(Required = Required.Always)]
        public override StationStatusData Data { get; set; }
    }
}