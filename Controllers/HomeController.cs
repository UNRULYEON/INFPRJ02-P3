﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using INFPRJ02_P3.Models;

namespace INFPRJ02_P3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Criminaliteit()
        {
            ViewData["Message"] = "Criminaliteit.";

            return View();
        }

        public IActionResult Recreatie()
        {
            ViewData["Message"] = "Recreatie";

            return View();
        }

        public IActionResult Luchtkwaliteit()
        {
            ViewData["Message"] = "Luchtkwaliteit";

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
