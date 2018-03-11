using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Internal;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Models;
using MvcMovie.Models;

namespace MvcMovie
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
           
            return View();
        }
        public IActionResult About()
        {
            
            ViewData["Message"] = "Your application description page.";
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Deelvraag(int? value)
        {
            ViewData["Message"] = "deelvraag 3.";
            var list = new List<SelectListItem>();
            var temp = MvcMovie.Request.GetRequest("https://opendata.cbs.nl/ODataApi/OData/82809NED/Leeftijd");
            foreach (var entry in temp.Value)
            {
                SelectListItem tmp = new SelectListItem{ Text = entry.Title, Value = entry.Key};
                list.Add(tmp);
            }

            if (value != null)
            {
                list.First(i => i.Value == value.ToString()).Selected = true;
            }
            ViewBag.lfd = list;
            var migratie = MvcMovie.Request.GenerateFromJson("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet","$top=1000&$filter=Migratieachtergrond eq '2012657' or Migratieachtergrond eq '2012655'");
            return View(migratie);
        }
        public IActionResult FilteredDeelvraag(string id = "")
        {
            ViewData["Message"] = "deelvraag 3.";
            var migratie = MvcMovie.Request.GenerateFromJson("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet","$top=100&$filter=Migratieachtergrond eq '2012657' or Migratieachtergrond eq '2012655'");
            return View("Deelvraag");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
