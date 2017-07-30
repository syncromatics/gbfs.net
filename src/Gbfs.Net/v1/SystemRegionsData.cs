using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describe regions for a system that is broken up by geographic or political region. It is defined as a separate feed to allow for additional region metadata (such as shape definitions).
    /// </summary>
    public class SystemRegionsData
    {
        /// <summary>
        /// Array of region objects
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public List<Region> Regions { get; set; }
    }
}