using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CarApi.Models
{

    public class CarData
    {
        //private string _imageBaseURL = "http://localhost:49345/api/image/getimage";
        private string _imageBaseURL;
        private string _imageURLPath = "api/image/getimage";

        public CarData(string baseAddress)
        {
            _imageBaseURL = baseAddress + _imageURLPath;
        }
                    
        public List<UpcomingCars> _upcomingCars = new List<UpcomingCars>()
        {
            new UpcomingCars{Name = "New Range Rover Evoque", LaunchDate ="Jun 2019", EstimatedPrice = "53 - 70 Lakhs", ImageURL = "RoverEvoque" },
            new UpcomingCars{Name = "MG  Hector", LaunchDate ="18 - 23 Lakhs", EstimatedPrice = "April 2018", ImageURL = "MGHector" },
            new UpcomingCars{Name = "Hyundai  Venue", LaunchDate ="21st May 2019", EstimatedPrice = "8 - 10 Lakhs", ImageURL = "HyundaiVenue" },
            new UpcomingCars{Name = "Jaguar  E-Pace", LaunchDate ="Jun 2019", EstimatedPrice = "50 - 60 Lakhs", ImageURL = "JaguarE-Pace" },
            new UpcomingCars{Name = "Hyundai  Kona", LaunchDate ="Jun 2019", EstimatedPrice = "8 - 14 Lakhs", ImageURL = "HyundaiKona" }
        };

        public List<LaunchedCars> _launchedCars = new List<LaunchedCars>()
        {
            new LaunchedCars{Name = "BMW X5", StartingPrice = "87.84 Lakhs",ImageURL = "BMWX5"},
            new LaunchedCars{Name = "Mahindra TUV300", StartingPrice = "9.88 Lakhs",ImageURL = "MahindraTUV300"},
            new LaunchedCars{Name = "Honda Civic", StartingPrice = "21.3 Lakhs",ImageURL = "HondaCivic"},
            new LaunchedCars{Name = "Honda CR-V", StartingPrice = "33.78 Lakhs",ImageURL = "HondaCR-V"},
            new LaunchedCars{Name = "Mahindra Marazzo", StartingPrice = "12.38 Lakhs",ImageURL = "MahindraMarazzo"}
        };

        public List<LaunchedCars> _popularCars = new List<LaunchedCars>()
        {
            new LaunchedCars{Name = "Maruti Suzuki Swift", StartingPrice = "5.83 Lakhs",ImageURL = "MarutiSuzukiSwift"},
            new LaunchedCars{Name = "Tata Harrier", StartingPrice = "15.59 Lakhs",ImageURL = "TataHarrier"},
            new LaunchedCars{Name = "Renault Kwid", StartingPrice = "3.33 Lakhs",ImageURL = "RenaultKwid"},
            new LaunchedCars{Name = "Maruti Suzuki Vitara Brezza", StartingPrice = "9.19 Lakhs",ImageURL = "MarutiSuzukiVitaraBrezza"},
            new LaunchedCars{Name = "Toyota Innova Crysta", StartingPrice = "18.25 Lakhs",ImageURL = "ToyotaInnovaCrysta"}
        };
        
        public List<UpcomingCars> GetUpcomingCars()
        {
            foreach(var car in _upcomingCars)
            {
                car.ImageURL = GetImageURL("UpcomingCars", car.ImageURL);
            }
            return _upcomingCars;
        }

        public List<LaunchedCars> GetLaunchedCars()
        {
            foreach (var car in _launchedCars)
            {
                car.ImageURL = GetImageURL("LaunchedCars", car.ImageURL);
            }
            return _launchedCars;
        }

        public List<LaunchedCars> GetPopularCars()
        {
            foreach (var car in _popularCars)
            {
                car.ImageURL = GetImageURL("PopularCars", car.ImageURL);
            }
            return _popularCars;
        }

        private string GetImageURL(string category, string name)
        {
            var completeURL = $"{ _imageBaseURL}?Category={category}&name={name}";
            return completeURL;
        }
            
    }
}
