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
        private CarviewContext _carviewContext;

        public CarData(string baseAddress)
        {
            _imageBaseURL = baseAddress + _imageURLPath;
            _carviewContext = new CarviewContext();
        }

        #region staticData

        //public List<UpcomingCars> _upcomingCars = new List<UpcomingCars>()
        //{
        //    new UpcomingCars{Name = "New Range Rover Evoque", LaunchDate ="Jun 2019", EstimatedPrice = "53 - 70 Lakhs", ImageURL = "RoverEvoque", Brand = LANDROVER },
        //    new UpcomingCars{Name = "MG  Hector", LaunchDate ="18 - 23 Lakhs", EstimatedPrice = "April 2018", ImageURL = "MGHector" , Brand = MG },
        //    new UpcomingCars{Name = "Hyundai  Venue", LaunchDate ="21st May 2019", EstimatedPrice = "8 - 10 Lakhs", ImageURL = "HyundaiVenue", Brand=HYUNDAI },
        //    new UpcomingCars{Name = "Jaguar  E-Pace", LaunchDate ="Jun 2019", EstimatedPrice = "50 - 60 Lakhs", ImageURL = "JaguarE-Pace" , Brand = JAGUAR },
        //    new UpcomingCars{Name = "Hyundai  Kona", LaunchDate ="Jun 2019", EstimatedPrice = "8 - 14 Lakhs", ImageURL = "HyundaiKona", Brand= HYUNDAI }
        //};

        //public List<LaunchedCars> _launchedCars = new List<LaunchedCars>()
        //{
        //    new LaunchedCars{Name = "BMW X5", StartingPrice = "87.84 Lakhs",ImageURL = "BMWX5", Brand = BMW},
        //    new LaunchedCars{Name = "Mahindra TUV300", StartingPrice = "9.88 Lakhs",ImageURL = "MahindraTUV300", Brand = MAHINDRA},
        //    new LaunchedCars{Name = "Honda Civic", StartingPrice = "21.3 Lakhs",ImageURL = "HondaCivic", Brand = HONDA},
        //    new LaunchedCars{Name = "Honda CR-V", StartingPrice = "33.78 Lakhs",ImageURL = "HondaCR-V", Brand = HONDA},
        //    new LaunchedCars{Name = "Mahindra Marazzo", StartingPrice = "12.38 Lakhs",ImageURL = "MahindraMarazzo", Brand = MAHINDRA}
        //};

        //public List<LaunchedCars> _popularCars = new List<LaunchedCars>()
        //{
        //    new LaunchedCars{Name = "Maruti Suzuki Swift", StartingPrice = "5.83 Lakhs",ImageURL = "MarutiSuzukiSwift",Brand=MARUTISUZUKI},
        //    new LaunchedCars{Name = "Tata Harrier", StartingPrice = "15.59 Lakhs",ImageURL = "TataHarrier",Brand =TATA},
        //    new LaunchedCars{Name = "Renault Kwid", StartingPrice = "3.33 Lakhs",ImageURL = "RenaultKwid", Brand=RENAULT},
        //    new LaunchedCars{Name = "Maruti Suzuki Vitara Brezza", StartingPrice = "9.19 Lakhs",ImageURL = "MarutiSuzukiVitaraBrezza", Brand=MARUTISUZUKI},
        //    new LaunchedCars{Name = "Toyota Innova Crysta", StartingPrice = "18.25 Lakhs",ImageURL = "ToyotaInnovaCrysta", Brand = TOYOTA}
        //};

        //public List<LaunchedCars> _availableCars = new List<LaunchedCars>()
        //{
        //    new LaunchedCars{Name = "BMW X5", StartingPrice = "87.84 Lakhs",ImageURL = "BMWX5", Brand = BMW},
        //    new LaunchedCars{Name = "Mahindra TUV300", StartingPrice = "9.88 Lakhs",ImageURL = "MahindraTUV300", Brand = MAHINDRA},
        //    new LaunchedCars{Name = "Honda Civic", StartingPrice = "21.3 Lakhs",ImageURL = "HondaCivic", Brand = HONDA},
        //    new LaunchedCars{Name = "Honda CR-V", StartingPrice = "33.78 Lakhs",ImageURL = "HondaCR-V", Brand = HONDA},
        //    new LaunchedCars{Name = "Mahindra Marazzo", StartingPrice = "12.38 Lakhs",ImageURL = "MahindraMarazzo", Brand = MAHINDRA},
        //    new LaunchedCars{Name = "Maruti Suzuki Swift", StartingPrice = "5.83 Lakhs",ImageURL = "MarutiSuzukiSwift",Brand=MARUTISUZUKI},
        //    new LaunchedCars{Name = "Tata Harrier", StartingPrice = "15.59 Lakhs",ImageURL = "TataHarrier",Brand =TATA},
        //    new LaunchedCars{Name = "Renault Kwid", StartingPrice = "3.33 Lakhs",ImageURL = "RenaultKwid", Brand=RENAULT},
        //    new LaunchedCars{Name = "Maruti Suzuki Vitara Brezza", StartingPrice = "9.19 Lakhs",ImageURL = "MarutiSuzukiVitaraBrezza", Brand=MARUTISUZUKI},
        //    new LaunchedCars{Name = "Toyota Innova Crysta", StartingPrice = "18.25 Lakhs",ImageURL = "ToyotaInnovaCrysta", Brand = TOYOTA},
        //    new LaunchedCars{Name = "Maruti Suzuki S-Cross", StartingPrice = "10.27 Lakhs", ImageURL = "SCross", Brand = MARUTISUZUKI},
        //    new LaunchedCars{Name = "Maruti Suzuki Celerio", StartingPrice = "5.13 Lakhs", ImageURL = "Celerio", Brand = MARUTISUZUKI},
        //    new LaunchedCars{Name = "Maruti Suzuki Dzire", StartingPrice = "6.8 Lakhs", ImageURL = "Dzire", Brand = MARUTISUZUKI},
        //    new LaunchedCars{Name = "Maruti Suzuki Wagon R", StartingPrice = "5.1 Lakhs", ImageURL = "WagonR", Brand = MARUTISUZUKI},
        //    new LaunchedCars{Name = "Maruti Suzuki Ertiga", StartingPrice = "8.64 Lakhs", ImageURL = "Ertiga", Brand = MARUTISUZUKI},
        //    new LaunchedCars{Name = "Maruti Suzuki Baleno", StartingPrice = "6.63 Lakhs", ImageURL = "Baleno", Brand = MARUTISUZUKI}
        //};

        //public List<UpcomingCars> GetUpcomingCars()
        //{

        //    foreach(var car in _upcomingCars)
        //    {
        //        car.ImageURL = GetImageURL("UpcomingCars", car.ImageURL);
        //    }
        //    return _upcomingCars;
        //}

        //public List<LaunchedCars> GetLaunchedCars()
        //{

        //    foreach (var car in _launchedCars)
        //    {
        //        car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
        //    }
        //    return _launchedCars;

        //}

        //public List<LaunchedCars> GetPopularCars()
        //{
        //    foreach (var car in _popularCars)
        //    {
        //        car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
        //    }
        //    return _popularCars;
        //}

        //public List<LaunchedCars> GetAvailableCars()
        //{
        //    foreach(var car in _availableCars)
        //    {
        //        car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
        //    }
        //    return _availableCars;
        //}

        //private string GetImageURL(string category, string name)
        //{
        //    var completeURL = $"{ _imageBaseURL}?Category={category}&name={name}";
        //    return completeURL;
        //}

        #endregion

        public List<string> GetBrands()
        {
            var brands = new List<string>
            {
                CarData.HYUNDAI,
                CarData.MARUTISUZUKI,
                CarData.TATA,
                CarData.RENAULT,
                CarData.TOYOTA,
                CarData.HONDA,
                CarData.MAHINDRA,
                CarData.BMW,
                CarData.MG,
                CarData.JAGUAR,
                CarData.LANDROVER
            };

            return brands;
        }

        public List<string> GetDealer()
        {
            var dealer = new List<string>
            {
                "Ahmedabad",
                "Bangalore",
                "Chennai",
                "Coimbatore",
                "Mumbai",
                "Delhi"
            };
            return dealer;
        }

        public const string HYUNDAI = "Hyundai";
        public const string MARUTISUZUKI = "MarutiSuzuki";
        public const string TATA = "Tata";
        public const string RENAULT = "Renault";
        public const string TOYOTA = "Toyota";
        public const string HONDA = "Honda";
        public const string MAHINDRA = "Mahindra";
        public const string BMW = "BMW";
        public const string MG = "MG";
        public const string JAGUAR = "Jaguar";
        public const string LANDROVER = "LandRover";

    }

}
