using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes current system alerts.
    /// </summary>
    [Description("Describes current system alerts.")]
    public class SystemAlerts : GbfsFile<SystemAlertsData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemAlertsData Data {get;set;}
    }
}