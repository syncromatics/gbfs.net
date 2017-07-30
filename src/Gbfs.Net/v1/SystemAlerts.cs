namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes current system alerts.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class SystemAlerts : GbfsFile<SystemAlertsData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override SystemAlertsData Data {get;set;}
    }
}