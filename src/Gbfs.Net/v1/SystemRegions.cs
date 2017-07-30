namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the regions the system is broken up into.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class SystemRegions : GbfsFile<SystemRegionsData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override SystemRegionsData Data { get; set; }
    }
}