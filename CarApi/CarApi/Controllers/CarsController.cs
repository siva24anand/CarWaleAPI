using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    
    [Route("api/cars")]
    [ApiController]
    public class CarsController : ControllerBase
    {
      CarData _cardata;

        public CarsController()
        {
            _cardata = new CarData();
        }

        [HttpGet("GetUpcomingCar")]
        public UpcomingCar GetUpcomingCar()
        {
            var car = new UpcomingCar()
            {
                Brand = "",
                ImageURL = "https://imgd.aeplcdn.com/310x174/cw/ec/37721/Land-Rover-New-Range-Rover-Evoque-Exterior-145496.jpg?wm=0&q=85",
                LaunchDate = "Jun 2019",
                Name = "Land Rover  New Range Rover Evoque",
                Price = "53 - 70 Lakhs",
                Type = ""
            };
            return car;
        }

        [HttpGet("GetUpcomingCars")]
        public List<UpcomingCar> GetUpcomingCars()
        {
            return _cardata.UpcomingCarValues();
        }

        [HttpGet("GetName")]
        public string GetName()
        {
            return "debug data";
        }

    }
}
