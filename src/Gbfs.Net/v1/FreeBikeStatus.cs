using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes bikes that are available in non station-based systems.
    /// </summary>
    [Description("Describes bikes that are available in non station-based systems.")]
    public class FreeBikeStatus : GbfsFile<FreeBikeStatusData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override FreeBikeStatusData Data { get; set; }
    }
}