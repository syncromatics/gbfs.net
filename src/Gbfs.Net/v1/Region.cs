namespace Gbfs.Net.v1
{
    /// <summary>
    /// A region object.
    /// </summary>
    public class Region
    {

        /// <summary>
        /// Unique identifier for the region
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string RegionId { get; set; }

        /// <summary>
        /// Public name for this region
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string Name { get; set; }
    }
}