using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Options;
using Microsoft.Extensions.Options;

namespace CarApi.Controllers
{
    [Route("api/Dealer")]
    [ApiController]
    public class DealerController : ControllerBase
    {
        private CarData _cardata;
        private readonly AppSettings _appSettings;
        private CarviewContext _carviewContext;

        public DealerController(IOptions<AppSettings> appsetting)
        {
            _appSettings = appsetting.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
            _carviewContext = new CarviewContext();
        }

        [HttpGet("GetDealers")]
        public List<string> GetDealers(string brandName)
        {
            return _carviewContext.Dealers.Where(d => d.IsActive == true && d.Brand.Name == brandName).Select(d => d.Location).Distinct().ToList();
        }
    }
}