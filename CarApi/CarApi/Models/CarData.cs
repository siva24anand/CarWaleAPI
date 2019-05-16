using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{
  public class CarData
  {
    public static List<FeaturedCar> _featuredCars = new List<FeaturedCar>()
    {
      new FeaturedCar{Name = "Land Rover  New Range Rover Evoque",Price ="53 - 70 Lakhs", LaunchDate = "Jun 2019", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/37721/Land-Rover-New-Range-Rover-Evoque-Exterior-145496.jpg?wm=0&q=85" },
      new FeaturedCar{Name = "MG  Hector",Price ="18 - 23 Lakhs", LaunchDate = "April 2018", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/36756/MG-Hector-Exterior-145971.jpg?wm=0&q=85" },
      new FeaturedCar{Name = "Maruti Suzuki New Vitara Brezza",Price ="8 - 9 Lakhs", LaunchDate = "Jun 2019", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/39028/Maruti-Suzuki-New-Vitara-Brezza-Exterior-152362.jpg?wm=0&q=85" }
    };
    public List<FeaturedCar> FeaturedCarValues()
    {
      return _featuredCars;
    }
        public static List<UpcomingCar> _upcomingCars = new List<UpcomingCar>()
    {
      new UpcomingCar{Name = "Land Rover  New Range Rover Evoque",Price ="53 - 70 Lakhs", LaunchDate = "Jun 2019", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/37721/Land-Rover-New-Range-Rover-Evoque-Exterior-145496.jpg?wm=0&q=85", Brand ="Land Rover", Type = "SUV" },
      new UpcomingCar{Name = "MG  Hector",Price ="18 - 23 Lakhs", LaunchDate = "April 2018", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/36756/MG-Hector-Exterior-145971.jpg?wm=0&q=85" , Brand ="MG", Type = "SUV"},
      new UpcomingCar{Name = "Maruti Suzuki New Vitara Brezza",Price ="8 - 9 Lakhs", LaunchDate = "Jun 2019", ImageURL ="https://imgd.aeplcdn.com/310x174/cw/ec/39028/Maruti-Suzuki-New-Vitara-Brezza-Exterior-152362.jpg?wm=0&q=85" , Brand ="Maruti", Type = "SUV"}
    };
        
        public List<UpcomingCar> UpcomingCarValues()
        {
            return _upcomingCars;
        }
    }
}
