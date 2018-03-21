using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;

namespace MvcMovie
{
    public class deelvraag2 : Controller
    {
        public IActionResult Index(Deelvraag2FilterOptions filter)
        {
            if (filter != null)
            {
                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/odata/81953NED/TypedDataSet?";
                ViewData["waardeklas"] = filter.WOZWaardeklassen;
                ViewData["bruto"] = filter.BrutoInkomen;
                ViewData["Huishouden"] = filter.Huishoudens;
            }
            var filters = new Deelvraag2FilterOptions()
            {
                selectedWOZWaardeklassen = MvcMovie.Request.CreateList("81953NED/WOZWaardeklassen"),
                selectedBrutoInkomen = MvcMovie.Request.CreateList("81953NED/BrutoInkomen"),
                selectedHuishoudens = MvcMovie.Request.CreateList("81953NED/Huishoudens"),
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}
