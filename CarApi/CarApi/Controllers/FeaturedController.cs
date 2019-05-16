using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    [Route("api/featured")]
    [ApiController]
    public class FeaturedController : ControllerBase
    {
        CarData _cardata;
        public FeaturedController()
        {
            _cardata = new CarData();
        }
        [HttpGet("GetUpcomingCars")]
        public List<UpcomingCars> GetUpcomingCars()
        {
            return _cardata.GetUpcomingCars();
        }

        [HttpGet("GetLaunchedCars")]
        public List<LaunchedCars> GetLaunchedCars()
        {
            return _cardata.GetLaunchedCars();
        }

        [HttpGet("GetPopularCars")]
        public List<LaunchedCars> GetPopularCars()
        {
            return _cardata.GetPopularCars();
        }

    }
}