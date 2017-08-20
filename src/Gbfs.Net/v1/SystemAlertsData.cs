using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// This feed is intended to inform customers about changes to the system that do not fall within the normal system operations.
    /// </summary>
    /// <remarks>
    /// For example, system closures due to weather would be listed here, but a system that only operated for part of the year would have that schedule listed in the system_calendar.json feed.
    /// This file is an array of alert objects defined. Obsolete alerts should be removed so the client application can safely present to the end user everything present in the feed. The consumer could use the start/end information to determine if this is a past, ongoing or future alert and adjust the presentation accordingly.
    /// </remarks>
    [Description("This feed is intended to inform customers about changes to the system that do not fall within the normal system operations.")]
    public class SystemAlertsData
    {
        /// <summary>
        /// Array - alert objects each indicating a separate system alert 
        /// </summary>
        [Description("Array - alert objects each indicating a separate system alert ")]
        [JsonProperty(Required = Required.Always)]
        [MinLength(0)]
        public List<Alert> Alerts { get; set; } = new List<Alert>();
    }
}