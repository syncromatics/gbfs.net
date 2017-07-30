namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes bikes that are available in non station-based systems.
    /// </summary>
    /// <remarks>
    /// This file is optional.
    /// </remarks>
    public class FreeBikeStatus : GbfsFile<FreeBikeStatusData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override FreeBikeStatusData Data { get; set; }
    }
}