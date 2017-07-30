using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <sumamry>
    /// This feed is intended to inform customers about changes to the system that do not fall within the normal system operations.
    /// </summary>
    /// <remarks>
    /// For example, system closures due to weather would be listed here, but a system that only operated for part of the year would have that schedule listed in the system_calendar.json feed.
    /// This file is an array of alert objects defined. Obsolete alerts should be removed so the client application can safely present to the end user everything present in the feed. The consumer could use the start/end information to determine if this is a past, ongoing or future alert and adjust the presentation accordingly.
    /// </remarks>
    public class SystemAlertsData {
        /// <summary>
        /// Array - alert objects each indicating a separate system alert 
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public List<Alert> Alerts {get;set;}
    }
}