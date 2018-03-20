using Microsoft.AspNetCore.Mvc;
using Models;

namespace MvcMovie
{
    public class deelvraag1 : Controller
    {
        public IActionResult Index(Deelvraag1FilterOptions filter)
        {
            if (filter != null)
            {
                //var migratie = "https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?$top=1000&" + age + " and " + gender + " and " + background + " and " + period;
                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/OData/83599NED/TypedDataSet?";
                ViewData["bedrijfstak"] = filter.Bedrijfstak;
                ViewData["regio"] = filter.Regio;
                ViewData["period"] = filter.Period;
               /* var migratie2 = HttpUtility.HtmlEncode("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?$top=1000&" + age + " and " + gender + " and " + background2 + " and " + period);
                ViewData["migratie"] = migratie;
                ViewData["migratie2"] = migratie2;
                ViewBag.Mig = migratie;*/
            }
            var filters = new Deelvraag1FilterOptions()
            {
                SelectedBedrijfstak = MvcMovie.Request.CreateList("83599NED/BedrijfstakkenBranchesSBI2008"),
                SelectedRegio = MvcMovie.Request.CreateList("83599NED/RegioS"),
                SelectedPeriod = MvcMovie.Request.CreateList("83599NED/Perioden"),
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}