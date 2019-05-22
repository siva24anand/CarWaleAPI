using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CarApi.Controllers
{
    [Route("api/featured")]
    [ApiController]
    [Authorize]
    public class FeaturedController : ControllerBase
    {
        private CarData _cardata;
        private readonly AppSettings _appSettings;

        public FeaturedController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
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