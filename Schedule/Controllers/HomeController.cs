﻿using Microsoft.AspNetCore.Mvc;
using Schedule.Models;
using System.Diagnostics;

namespace Schedule.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpGet]

        //METHOD TO DISPLAY RANDOM SHIT ON A PAGE
        public IActionResult MainPage()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Schedule() 
        {
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