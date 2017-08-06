using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Status of a single station
    /// </summary>
    [Description("Status of a single station")]
    public class Status
    {
        /// <summary>
        /// Unique identifier of a station (<see cref="StationInformation" />)
        /// </summary>
        [Description("Unique identifier of a station (see station_information)")]
        [JsonProperty(Required = Required.Always)]
        public string StationId { get; set; }

        /// <summary>
        /// Number of bikes available for rental
        /// </summary>
        [Description("Number of bikes available for rental")]
        [JsonProperty(Required = Required.Always)]
        public int NumBikesAvailable { get; set; }

        /// <summary>
        /// Number of disabled bikes at the station. 
        /// </summary>
        /// <remarks>
        /// Vendors who do not want to publicize the number of disabled bikes or docks in their system can opt to omit station capacity (in <see cref="StationInformation" />), <see cref="NumBikesDisabled"/> and <see cref="NumDocksDisabled"/>. If station capacity is published then broken docks/bikes can be inferred (though not specifically whether the decreased capacity is a broken bike or dock)
        /// </remarks>
        [Description("Number of disabled bikes at the station. ")]
        [JsonProperty(Required = Required.DisallowNull)]
        public int? NumBikesDisabled { get; set; }

        /// <summary>
        /// Number of docks accepting bike returns.
        /// </summary>
        [Description("Number of docks accepting bike returns.")]
        [JsonProperty(Required = Required.Always)]
        public int NumDocksAvailable { get; set; }

        /// <summary>
        /// Number of empty but disabled dock points at the station. This value remains as part of the spec as it is possibly useful during development.
        /// </summary>
        [Description("Number of empty but disabled dock points at the station. This value remains as part of the spec as it is possibly useful during development.")]
        [JsonProperty(Required = Required.DisallowNull)]
        public int? NumDocksDisabled { get; set; }

        /// <summary>
        /// Is the station currently on the street
        /// </summary>
        [JsonIgnore]
        public bool IsInstalled
        {
            get { return _isInstalled != 0; }
            set { _isInstalled = value ? 1 : 0; }
        }

        [Description("Is the station currently on the street")]
        [JsonProperty("is_installed", Required = Required.Always)]
        [Range(0, 1)]
        private int _isInstalled { get; set; }

        /// <summary>
        /// Is the station currently renting bikes (even if the station is empty, if it is set to allow rentals this value should be true)
        /// </summary>
        [JsonIgnore]
        public bool IsRenting
        {
            get { return _isRenting != 0; }
            set { _isRenting = value ? 1 : 0; }
        }

        [Description("Is the station currently renting bikes (even if the station is empty, if it is set to allow rentals this value should be true)")]
        [JsonProperty("is_renting", Required = Required.Always)]
        [Range(0, 1)]
        private int _isRenting { get; set; }

        /// <summary>
        /// Is the station accepting bike returns (if a station is full but would allow a return if it was not full then this value should be true)
        /// </summary>
        [JsonIgnore]
        public bool IsReturning
        {
            get { return _isReturning != 0; }
            set { _isReturning = value ? 1 : 0; }
        }

        [Description("Is the station accepting bike returns (if a station is full but would allow a return if it was not full then this value should be true)")]
        [JsonProperty("is_returning", Required = Required.Always)]
        [Range(0, 1)]
        private int _isReturning {get;set;}

        /// <summary>
        /// Integer POSIX timestamp indicating the last time this station reported its status to the backend
        /// </summary>
        [Description("Integer POSIX timestamp indicating the last time this station reported its status to the backend")]
        [JsonProperty(Required = Required.Always)]
        public long LastReported { get; set; }
    }
}