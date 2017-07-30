using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the operating calendar for a system. An array of year objects defined as follows (if start/end year are omitted, then assume the start and end months do not change from year to year).
    /// </summary>
    public class SystemCalendarData
    {
        /// <summary>
        /// Array of year objects describing the system operational calendar. A minimum of one calendar object is required, which could indicate a general calendar, or multiple calendars could be present indicating arbitrary start and end dates.
        /// </summary>
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
    }
}