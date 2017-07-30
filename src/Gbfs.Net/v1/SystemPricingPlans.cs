namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system pricing.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class SystemPricingPlans : GbfsFile<SystemPricingPlansData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override SystemPricingPlansData Data { get; set; }
    }
}