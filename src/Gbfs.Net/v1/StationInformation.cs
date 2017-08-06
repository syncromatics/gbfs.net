using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Mostly static list of all stations, their capacities and locations.
    /// </summary>
    [Description("Mostly static list of all stations, their capacities and locations.")]
    public class StationInformation : GbfsFile<StationInformationData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override StationInformationData Data { get; set; }
    }
}