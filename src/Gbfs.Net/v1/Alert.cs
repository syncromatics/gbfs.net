using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// An alert object indicating a system alert
    /// </summary>
    public class Alert {
        
        /// <summary>
        /// ID - unique identifier for this alert
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string AlertId {get;set;}
        
        /// <summary>
        /// Enumerable - valid values are:
        /// <list>
        ///   <item><term>SYSTEM_CLOSURE</term></item> 
        ///   <item><term>STATION_CLOSURE</term></item> 
        ///   <item><term>STATION_MOVE</term></item> 
        ///   <item><term>OTHER</term></item>
        /// </list>
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string Type {get;set;}
        
        /// <summary>
        /// Array alert times indicating when the alert is in effect (e.g. when the system or station is actually closed, or when it is scheduled to be moved). If this array is omitted then the alert should be displayed as long as it is in the feed.
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public List<AlertTime> Times {get;set;}
        
        /// <summary>
        /// If this is an alert that affects one or more stations, include their ids, otherwise omit this field. If both <see cref="StationIds" /> and <see cref="RegionIds"/> are omitted, assume this alert affects the entire system
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public List<string> StationIds {get;set;}
        
        /// <summary>
        /// If this system has regions, and if this alert only affects certain regions, include their ids, otherwise, omit this field. If both <see cref="StationIds" /> and <see cref="RegionIds"/> are omitted, assume this alert affects the entire system
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public List<string> RegionIds {get;set;}
        
        /// <summary>
        /// URL where the customer can learn more information about this alert, if there is one
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public string Url {get;set;}
        
        /// <summary>
        /// A short summary of this alert to be displayed to the customer
        /// </summary>
        /// <remarks>
        /// This property is required.
        /// </remarks>
        public string Summary {get;set;}
        
        /// <summary>
        /// Detailed text description of the alert
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public string Description {get;set;}
        
        /// <summary>
        /// Integer POSIX timestamp indicating the last time the info for the particular alert was updated
        /// </summary>
        /// <remarks>
        /// This property is optional.
        /// </remarks>
        public long LastUpdated {get;set;}
    }
}