using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class UpcomingCars : FeaturedCars
    {
        public string LaunchDate { get; set; }
        public string EstimatedPrice { get; set; }
    }
}
