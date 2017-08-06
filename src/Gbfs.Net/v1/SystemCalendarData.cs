using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the operating calendar for a system. An array of year objects defined as follows (if start/end year are omitted, then assume the start and end months do not change from year to year).
    /// </summary>
    [Description("Describes the operating calendar for a system. An array of year objects defined as follows (if start/end year are omitted, then assume the start and end months do not change from year to year).")]
    public class SystemCalendarData
    {
        /// <summary>
        /// Array of year objects describing the system operational calendar. A minimum of one calendar object is required, which could indicate a general calendar, or multiple calendars could be present indicating arbitrary start and end dates.
        /// </summary>
        [Description("Array of year objects describing the system operational calendar. A minimum of one calendar object is required, which could indicate a general calendar, or multiple calendars could be present indicating arbitrary start and end dates.")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(1)]
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();
    }
}