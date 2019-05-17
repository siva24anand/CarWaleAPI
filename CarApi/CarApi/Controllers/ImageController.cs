using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;

namespace CarApi.Controllers
{
    [Route("api/Image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        [HttpGet("GetImage")]
        public IActionResult GetImage()
        {
            return new PhysicalFileResult(@"..\Images\Rover.PNG", "image/jpeg");
            //var image = System.IO.File.OpenRead(@"..\Images\Rover.PNG");
            //return File(image, "image/jpeg");
        }
    }
}