using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{

    public class CarData
    {
                    
        public static List<UpcomingCars> _upcomingCars = new List<UpcomingCars>()
        {
            new UpcomingCars{Name = "Land Rover  New Range Rover Evoque", LaunchDate ="Jun 2019", EstimatedPrice = "53 - 70 Lakhs", ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/37721/Land-Rover-New-Range-Rover-Evoque-Exterior-145496.jpg?wm=0&q=85"},
            new UpcomingCars{Name = "MG  Hector", LaunchDate ="18 - 23 Lakhs", EstimatedPrice = "April 2018", ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/36756/MG-Hector-Exterior-145971.jpg?wm=0&q=85"},
            new UpcomingCars{Name = "Hyundai  Venue", LaunchDate ="21st May 2019", EstimatedPrice = "8 - 10 Lakhs", ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/35455/Hyundai-Venue-Exterior-154436.jpg?wm=0&q=85"},
            new UpcomingCars{Name = "Jaguar  E-Pace", LaunchDate ="Jun 2019", EstimatedPrice = "50 - 60 Lakhs", ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/31125/Jaguar-EPace-Exterior-108050.jpg?wm=0&q=85"},
            new UpcomingCars{Name = "Hyundai  Kona", LaunchDate ="Jun 2019", EstimatedPrice = "8 - 14 Lakhs", ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/29580/Hyundai-Kona-Exterior-99402.jpg?wm=0&q=85"}
        };

        public static List<LaunchedCars> _launchedCars = new List<LaunchedCars>()
        {
            new LaunchedCars{Name = "BMW X5", StartingPrice = "87.84 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/37065/BMW-X5-Right-Front-Three-Quarter-157119.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Mahindra TUV300", StartingPrice = "9.88 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/39470/Mahindra-TUV300-Right-Front-Three-Quarter-155763.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Honda Civic", StartingPrice = "21.3 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/27074/Honda-New-Civic-Right-Front-Three-Quarter-148154.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Honda CR-V", StartingPrice = "33.78 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/34457/Honda-CRV-Exterior-137861.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Mahindra Marazzo", StartingPrice = "12.38 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/26944/Mahindra-Marazzo-Exterior-136980.jpg?wm=0&q=85"}
        };

        public static List<LaunchedCars> _popularCars = new List<LaunchedCars>()
        {
            new LaunchedCars{Name = "Maruti Suzuki Swift", StartingPrice = "5.83 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/26742/Maruti-Suzuki-New-Swift-Exterior-117654.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Tata Harrier", StartingPrice = "15.59 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/32958/Tata-Harrier-Right-Front-Three-Quarter-142878.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Renault Kwid", StartingPrice = "3.33 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/39224/Renault-New-Kwid-Right-Front-Three-Quarter-153622.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Maruti Suzuki Vitara Brezza", StartingPrice = "9.19 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/21609/Maruti-Suzuki-Vitara-Brezza-Right-Front-Three-Quarter-118639.jpg?wm=0&q=85"},
            new LaunchedCars{Name = "Toyota Innova Crysta", StartingPrice = "18.25 Lakhs",ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/20623/Toyota-Innova-Crysta-Exterior-134987.jpg?wm=0&q=85"}
        };
        
        public List<UpcomingCars> GetUpcomingCars()
        {
            return _upcomingCars;
        }

        public List<LaunchedCars> GetLaunchedCars()
        {
            return _launchedCars;
        }

        public List<LaunchedCars> GetPopularCars()
        {
            return _popularCars;
        }
            
    }
}
