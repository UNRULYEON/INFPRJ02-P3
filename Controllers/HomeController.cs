using System;
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

        public IActionResult oSubteamOne()
        {
            ViewData["Message"] = "Subteam 1.";

            return View();
        }

        public IActionResult oSubteamTwo()
        {
            ViewData["Message"] = "Subteam 2.";

            return View();
        }

        public IActionResult oSubteamThree()
        {
            ViewData["Message"] = "Subteam 3.";

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
