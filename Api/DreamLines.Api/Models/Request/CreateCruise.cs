using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DreamLines.Api.Models.Request
{
    public class CreateCruise
    {
        public int nid { get; set; }
        public int shipId { get; set; }
        public int cabinType { get; set; }
        public List<Route> rid { get; set; }
        public DateTime departureDate { get; set; }
        public bool isFlight { get; set; }
    }

    public class Route {
        public int Day { get; set; }
        public string Port { get; set; }
    }
}
