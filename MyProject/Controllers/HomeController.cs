using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MyProject.Models;
using MyProject.ViewsModels;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;

        public HomeController(IStringLocalizer<HomeController> localizer)
        {
            _localizer = localizer;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Route("Home/About")]
        public IActionResult About()
        {
            ViewData["Message"] = _localizer["MessageAbout"];

            return View();
        }
        [Route("Partners")]
        public IActionResult Partners()
        {
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = _localizer["MessageContact"];

            return View();
        }    

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
