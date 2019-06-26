﻿using System;
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

        public BrandController(IOptions<AppSettings> appsettings)
        {
            _appSettings = appsettings.Value;
            _cardata = new CarData(_appSettings.CarWaleApiBaseURL);
        }

        [HttpGet("GetBrands")]
        public List<string> GetBrands()
        {
            return _cardata.GetBrands();
        }
    }
}