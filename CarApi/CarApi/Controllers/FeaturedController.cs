using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;

namespace CarApi.Controllers
{
    [Route("api/featured")]
    [ApiController]
    [Authorize]
    public class FeaturedController : ControllerBase
    {
        private CarData _cardata;
        private readonly AppSettings _appSettings;
        private CarviewContext _carviewContext;
        private string _imageURLPath = "api/image/getimage";
        private string _imageBaseURL;

        public FeaturedController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
            _carviewContext = new CarviewContext();
            _imageBaseURL = _appSettings.CarWaleApiBaseURL + _imageURLPath;
        }

        [HttpGet("GetUpcomingCars")]
        public List<Car> GetUpcomingCars()
        {
            var upcomingCars = _carviewContext.Cars.Where(c => c.IsUpcoming == true).ToList();
            foreach (var car in upcomingCars)
            {
                car.ImageURL = GetImageURL("UpcomingCars", car.ImageURL);
            }

            return upcomingCars;
        }

        [HttpGet("GetLaunchedCars")]
        public List<Car> GetLaunchedCars()
        {
            var launchedCars = _carviewContext.Cars.Where(c => c.IsLaunched == true).ToList();
            foreach (var car in launchedCars)
            {
                car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
            }

            return launchedCars;
        }

        [HttpGet("GetPopularCars")]
        public List<Car> GetPopularCars()
        {
            var popularCars = _carviewContext.Cars.Where(c => c.IsLaunched == false && c.IsUpcoming == false).ToList();
            foreach (var car in popularCars)
            {
                car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
            }

            return popularCars;
        }

        [HttpGet("GetAvailableCars")]
        public List<Car> GetAvailableCars()
        {
            var availableCars = _carviewContext.Cars.Where(c => c.IsUpcoming == false).Include(b=>b.Brand).ToList();
            foreach (var car in availableCars)
            {
                car.ImageURL = GetImageURL("AvailableCars", car.ImageURL);
            }
            return availableCars;
        }

        private string GetImageURL(string category, string name)
        {
            var completeURL = $"{ _imageBaseURL}?Category={category}&name={name}";
            return completeURL;
        }
    }
}