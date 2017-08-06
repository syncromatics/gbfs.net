using System;
using System.ComponentModel;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system including System operator, System location, year implemented, URLs, contact info, time zone.
    /// </summary>
    [Description("Describes the system including System operator, System location, year implemented, URLs, contact info, time zone.")]
    public class SystemInformation : GbfsFile<SystemInformationData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemInformationData Data { get; set; }
    }
}