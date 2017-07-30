using System;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system including System operator, System location, year implemented, URLs, contact info, time zone.
    /// </summary>
    public class SystemInformation : GbfsFile<SystemInformationData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override SystemInformationData Data { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}