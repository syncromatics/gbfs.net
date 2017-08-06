using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Range of time that an alert may be in effect
    /// </summary>
    [Description("Range of time that an alert may be in effect")]
    public class AlertTime
    {
        /// <summary>
        /// Integer POSIX timestamp - required if container "times" key is present
        /// </summary>
        [Description("Integer POSIX timestamp - required if container \"times\" key is present")]
        [JsonProperty(Required = Required.Always)]
        public long Start { get; set; }

        /// <summary>
        /// Integer POSIX timestamp - if there is currently no end time planned for the alert, this key can be omitted indicating that there is no currently scheduled end time for the alert
        /// </summary>
        [Description("Integer POSIX timestamp - if there is currently no end time planned for the alert, this key can be omitted indicating that there is no currently scheduled end time for the alert")]
        [JsonProperty(Required = Required.DisallowNull)]
        public long? End { get; set; }
    }
}