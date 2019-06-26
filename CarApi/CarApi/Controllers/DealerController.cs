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

        public DealerController(IOptions<AppSettings> appsetting)
        {
            _appSettings = appsetting.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
        }

        [HttpGet("GetDealers")]
        public List<string> GetDealers()
        {
            return _cardata.GetDealer();
        }
    }
}