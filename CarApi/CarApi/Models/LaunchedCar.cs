using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
    public class LaunchedCars:FeaturedCars
    {
        public string StartingPrice { get; set; }
    }
}
