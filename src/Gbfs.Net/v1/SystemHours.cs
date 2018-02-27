using System.ComponentModel;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the hours of operation for the system.
    /// </summary>
    [Description("Describes the hours of operation for the system.")]
    public class SystemHours : GbfsFile<SystemHoursData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemHoursData Data { get; set; }
    }
}