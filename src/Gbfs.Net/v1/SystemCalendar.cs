using System.ComponentModel;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the days of operation for the system.
    /// </summary>
    [Description("Describes the days of operation for the system.")]
    public class SystemCalendar : GbfsFile<SystemCalendarData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemCalendarData Data { get; set; }
    }
}