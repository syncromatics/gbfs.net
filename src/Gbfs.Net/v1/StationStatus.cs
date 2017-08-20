using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Number of available bikes and docks at each station and station availability.
    /// </summary>
    [Description("Number of available bikes and docks at each station and station availability.")]
    public class StationStatus : GbfsFile<StationStatusData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override StationStatusData Data { get; set; }
    }
}