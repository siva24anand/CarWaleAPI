using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Hosting;

namespace CarApi.Controllers
{
    [Route("api/Image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private string _imageFolder = "Images";
        private string _webpextension = ".webp";
        private string _pngextension = ".png";

        private readonly IHostingEnvironment _hostingEnvironment;
        public ImageController(IHostingEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }

        [HttpGet("GetImage")]
        public IActionResult GetImage(string category, string name)
        {
            var root = Path.Combine(_hostingEnvironment.ContentRootPath, _imageFolder, category, name + _webpextension);
            return new PhysicalFileResult(root, "image/webp");
        }

        [HttpGet("GetBannerImage")]
        public IActionResult GetBannerImage(string name)
        {
            var root = Path.Combine(_hostingEnvironment.ContentRootPath, _imageFolder, name + _pngextension);
            return new PhysicalFileResult(root, "image/webp");
        }
    }
}