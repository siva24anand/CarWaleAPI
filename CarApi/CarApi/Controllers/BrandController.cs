using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CarApi.Controllers
{
    [Route("api/Brand")]
    [ApiController]
    public class BrandController : ControllerBase
    {
        private CarData _cardata;
        private readonly AppSettings _appSettings;
        private CarviewContext _carviewContext;

        public BrandController(IOptions<AppSettings> appsettings)
        {
            _appSettings = appsettings.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
            _carviewContext = new CarviewContext();
        }

        [HttpGet("GetBrands")]
        public List<string> GetBrands()
        {
            var result = _carviewContext.Brands.Where(b => b.IsActive == true).Select(b=>b.Name).ToList();
            return result;
        }
    }
}