namespace Gbfs.Net.v1
{
    public class Status
    {
        /// <summary>
        /// Unique identifier of a station (<see cref="StationInformation" />)
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string StationId { get; set; }

        /// <summary>
        /// Number of bikes available for rental
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public int NumBikesAvailable { get; set; }

        /// <summary>
        /// Number of disabled bikes at the station. 
        /// </sumamry>
        /// <remarks>
        /// This property is optional.
        /// Vendors who do not want to publicize the number of disabled bikes or docks in their system can opt to omit station capacity (in <see cref="StationInformation" />), <see cref="NumBikesDisabled"/> and <see cref="NumDocksDisabled"/>. If station capacity is published then broken docks/bikes can be inferred (though not specifically whether the decreased capacity is a broken bike or dock)
        /// </remarks>
        public int NumBikesDisabled { get; set; }

        /// <summary>
        /// Number of docks accepting bike returns.
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public int NumDocksAvailable { get; set; }

        /// <summary>
        /// Number of empty but disabled dock points at the station. This value remains as part of the spec as it is possibly useful during development.
        /// </sumamry>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public int NumDocksDisabled { get; set; }

        /// <summary>
        /// Is the station currently on the street
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public bool IsInstalled { get; set; }

        /// <summary>
        /// Is the station currently renting bikes (even if the station is empty, if it is set to allow rentals this value should be true)
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public bool IsRenting { get; set; }

        /// <summary>
        /// Is the station accepting bike returns (if a station is full but would allow a return if it was not full then this value should be true)
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public bool IsReturning { get; set; }

        /// <summary>
        /// Integer POSIX timestamp indicating the last time this station reported its status to the backend
        /// </sumamry>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public long LastReported { get; set; }
    }
}