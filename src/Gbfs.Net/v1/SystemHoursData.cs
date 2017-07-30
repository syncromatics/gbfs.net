using System.Collections.Generic;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system hours of operation.
    /// </sumamry>
    public class SystemHoursData
    {
        /// <summary>
        /// Array of hour objects. Can contain a minimum of one object identifying hours for all days of the week or a maximum of fourteen hour objects are allowed (one for each day of the week for each "member" or "nonmember" user type)
        /// </summary>
        public List<RentalHours> RentalHours { get; set; }
    }
}