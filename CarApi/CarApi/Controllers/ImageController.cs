using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using Microsoft.Extensions.Hosting;
using CarApi.Models;

namespace CarApi.Controllers
{
    [Route("api/Image")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private string _imageFolder = "Images";
        private string _webpextension = ".webp";
        private string _pngextension = ".png";
        private string _adsCategory = "Ads";
        private string _otherCategory = "Others";

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

        [HttpGet("GetAdImage")]
        public IActionResult GetAdImage(string size)
        {
            var name = GetRandomImage(size);
            //var name = "Ad_vw";
            var root = Path.Combine(_hostingEnvironment.ContentRootPath, _imageFolder, _adsCategory, name + _pngextension);
            return new PhysicalFileResult(root, "image/webp");
        }

        [HttpGet("GetOtherImage")]
        public IActionResult GetOtherImage(string name)
        {
            var root = Path.Combine(_hostingEnvironment.ContentRootPath, _imageFolder, _otherCategory, name + _pngextension);
            return new PhysicalFileResult(root, "image/png");
        }

        private string GetRandomImage(string size)
        {
            var random = new Random();
            var adList = AdsModel.ADVSMALL;
            if(size == "small")
            {
                var index = random.Next(adList.Count);
                return adList[index];
            }
            return string.Empty;
            
        }

    }
}