﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;
using MyProject.Models;
using MyProject.ViewsModels;

namespace MyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly ApplicationContext allComments;

        public HomeController(IStringLocalizer<HomeController> localizer, ApplicationContext _allComments)
        {
            _localizer = localizer;
            allComments = _allComments;
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
            ViewBag.Comments = allComments.Comments.ToList();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );

            return LocalRedirect(returnUrl);
        }

    }
}
