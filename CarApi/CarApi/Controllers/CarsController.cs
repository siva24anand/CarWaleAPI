using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarApi.Controllers
{
    
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
      CarData _cardata;

      public CarsController()
      {
        _cardata = new CarData();
      }
      public List<UpcomingCar> GetUpcomingCars()
      {
        return _cardata.UpcomingCarValues();
      }

    }
}
