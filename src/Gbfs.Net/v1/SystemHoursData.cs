using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Gbfs.Net.v1
{
    /// <summary>
    /// Describes the system hours of operation.
    /// </summary>
    [Description("Describes the system hours of operation.")]
    public class SystemHoursData
    {
        /// <summary>
        /// Array of hour objects. Can contain a minimum of one object identifying hours for all days of the week or a maximum of fourteen hour objects are allowed (one for each day of the week for each "member" or "nonmember" user type)
        /// </summary>
        [Description("Array of hour objects. Can contain a minimum of one object identifying hours for all days of the week or a maximum of fourteen hour objects are allowed (one for each day of the week for each \"member\" or \"nonmember\" user type)")]
        [MinLength(0)]
        [MaxLength(14)]
        public List<RentalHours> RentalHours { get; set; } = new List<RentalHours>();
    }
}