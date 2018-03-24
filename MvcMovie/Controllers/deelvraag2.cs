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
                selectedBrutoInkomen = MvcMovie.Request.CreateList("81953NED/BrutoInkomen"),
                selectedPerioden = MvcMovie.Request.CreateList("81953NED/Perioden"),
                selectedRegioS = MvcMovie.Request.CreateList("81953NED/RegioS?$filter=endswith(Title,'PV)') eq true"),
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}
