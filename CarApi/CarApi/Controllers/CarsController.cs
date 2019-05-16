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
        public CarsController()
        {
            
        }
    }
}
