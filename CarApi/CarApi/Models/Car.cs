using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
  public class Car
  {
    public string Name { get; set; }
    public string Type { get; set; }
    public string Price { get; set; }
    public string Brand { get; set; }
  }

  public class FeaturedCar: Car
  {
    public string LaunchDate { get; set; }
    public string ImageURL { get; set; }
  }
    public class UpcomingCar: Car
    {
        public string LaunchDate { get; set; }
        public string ImageURL { get; set; }
    }

}
