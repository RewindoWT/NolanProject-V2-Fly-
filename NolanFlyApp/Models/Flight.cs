using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NolanFlyApp.Models
{
    public class Flight
    {
        public int id { get; set; }
        public string fromLocation { get; set; }
        public string toLocation { get; set; }
        public string departureDate { get; set; }
        public string departureTime { get; set; }

        // Relationship
        public int planeId { get; set; }
    }
}
