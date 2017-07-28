namespace Gbfs.Net
{

    public class StationStatus
    {
        public string StationId { get; set; }
        public int NumBikesAvailable { get; set; }
        public int NumBikesDisabled { get; set; }
        public int NumDocksAvailable { get; set; }
        public int NumDocksDisabled { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsRenting { get; set; }
        public bool IsReturning { get; set; }
        public long LastReported { get; set; }
    }
}
