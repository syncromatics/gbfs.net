using System.Collections.Generic;

namespace Gbfs.Net
{
    public class Station
    {
        public string StationId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public decimal Lat { get; set; }
        public decimal Lon { get; set; }
        public string Address { get; set; }
        public string CrossStreet { get; set; }
        public string RegionId { get; set; }
        public string PostCode { get; set; }
        public List<string> RentalMethods { get; set; }
        public int? Capacity { get; set; }
    }
}
