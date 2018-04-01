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

        public IActionResult Crimi()
        {
            ViewData["Message"] = "Criminaliteit.";

            return View();
        }
        
        public IActionResult Criminaliteit()
        {
            ViewData["Message"] = "Criminaliteit.";

            return View();
        }

        public IActionResult CriminaliteitGemiddeld()
        {
            ViewData["Message"] = "CriminaliteitGemiddeld";

            return View();
        }

        public IActionResult CriminaliteitCentrum()
        {
            ViewData["Message"] = "CriminaliteitCentrum";

            return View();
        }
        public IActionResult CriminaliteitCharlois()
        {
            ViewData["Message"] = "CriminaliteitCharlois";

            return View();
        }
        public IActionResult CriminaliteitDelfshaven()
        {
            ViewData["Message"] = "CriminaliteitDelfshaven";

            return View();
        }
        public IActionResult CriminaliteitFeijenoord()
        {
            ViewData["Message"] = "CriminaliteitFeijenoord";

            return View();
        }
        public IActionResult CriminaliteitHillegersebergSchiebroek()
        {
            ViewData["Message"] = "CriminaliteitHillegersebergSchiebroek";

            return View();
        }
        public IActionResult CriminaliteitIjselmonde()
        {
            ViewData["Message"] = "CriminaliteitIjselmonde";

            return View();
        }
        public IActionResult CriminaliteitKralingenCrooswijk()
        {
            ViewData["Message"] = "CriminaliteitKralingenCrooswijk";

            return View();
        }
        public IActionResult CriminaliteitNoord()
        {
            ViewData["Message"] = "CriminaliteitNoord";

            return View();
        }
        public IActionResult CriminaliteitOverschie()
        {
            ViewData["Message"] = "CriminaliteitOverschie";

            return View();
        }
        public IActionResult CriminaliteitPrinsAlexander()
        {
            ViewData["Message"] = "CriminaliteitPrinsAlexander";

            return View();
        }

        public IActionResult Recreatie()
        {
            ViewData["Message"] = "Recreatie";

            return View();
        }
        public IActionResult RecreatieCentrum()
        {
            ViewData["Message"] = "RecreatieCentrum";

            return View();
        }
        public IActionResult RecreatieCharlois()
        {
            ViewData["Message"] = "RecreatieCharlois";

            return View();
        }
        public IActionResult RecreatieDelfshaven()
        {
            ViewData["Message"] = "RecreatieDelfshaven";

            return View();
        }
        public IActionResult RecreatieFeijenoord()
        {
            ViewData["Message"] = "RecreatieFeijenoord";

            return View();
        }
        public IActionResult RecreatieHillegersebergSchiebroek()
        {
            ViewData["Message"] = "RecreatieHillegersebergSchiebroek";

            return View();
        }
        public IActionResult RecreatieIjselmonde()
        {
            ViewData["Message"] = "RecreatieIjselmonde";

            return View();
        }
        public IActionResult RecreatieKralingenCrooswijk()
        {
            ViewData["Message"] = "RecreatieKralingenCrooswijk";

            return View();
        }
        public IActionResult RecreatieNoord()
        {
            ViewData["Message"] = "RecreatieNoord";

            return View();
        }
        public IActionResult RecreatieOverschie()
        {
            ViewData["Message"] = "RecreatieOverschie";

            return View();
        }
        public IActionResult RecreatiePrinsAlexander()
        {
            ViewData["Message"] = "RecreatiePrinsAlexander";

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
