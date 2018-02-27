using System.ComponentModel;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system pricing.
    /// </summary>
    [Description("Describes the system pricing.")]
    public class SystemPricingPlans : GbfsFile<SystemPricingPlansData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        [Description("Object containing the data fields for this response")]
        public override SystemPricingPlansData Data { get; set; }
    }
}