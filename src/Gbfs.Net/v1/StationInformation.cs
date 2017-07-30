namespace Gbfs.Net.v1
{
    /// <summary>
    /// Mostly static list of all stations, their capacities and locations.
    /// </summary>
    public class StationInformation : GbfsFile<StationInformationData>
    {
        /// <summary>
        /// Object containing the data fields for this response
        /// </summary>
        public override StationInformationData Data { get; set; }
    }
}