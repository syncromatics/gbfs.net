using System;
using Newtonsoft.Json;

namespace Gbfs.Net
{
    public class StationStatus
    {
        public string StationId { get; set; }
        public int NumBikesAvailable { get; set; }
        public int? NumBikesDisabled { get; set; }
        public int NumDocksAvailable { get; set; }
        public int? NumDocksDisabled { get; set; }
        public bool IsInstalled { get; set; }
        public bool IsRenting { get; set; }
        public bool IsReturning { get; set; }
        [JsonProperty("last_reported")]
        public long LastReportedSeconds { get; set; }
        [JsonIgnore]
        public DateTimeOffset LastReported => DateTimeOffset.FromUnixTimeSeconds(LastReportedSeconds);
    }
}
