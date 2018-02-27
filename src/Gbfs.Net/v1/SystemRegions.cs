using System.ComponentModel;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the regions the system is broken up into.
    /// </summary>
    [Description("Describes the regions the system is broken up into.")]
    public class SystemRegions : GbfsFile<SystemRegionsData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemRegionsData Data { get; set; }
    }
}