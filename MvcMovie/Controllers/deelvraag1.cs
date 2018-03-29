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
                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/odata/81487ned/TypedDataSet?";
                ViewData["Perioden"] = filter.Perioden;
                ViewData["Kenmerkenwerknemer"] = filter.Kenmerkenwerknemer;
                ViewData["Criteria"] = filter.Criteria;
                ViewData["Coasector"] = filter.Coasector;
                
                //ViewData["Onderwijsvolgend"] = filter.Onderwijsvolgend;
               /* var migratie2 = HttpUtility.HtmlEncode("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?$top=1000&" + age + " and " + gender + " and " + background2 + " and " + period);
                ViewData["migratie"] = migratie;
                ViewData["migratie2"] = migratie2;
                ViewBag.Mig = migratie;*/
            }
            var filters = new Deelvraag1FilterOptions()
            {
                //SelectedBedrijfstak = MvcMovie.Request.CreateList("83599NED/BedrijfstakkenBranchesSBI2008"),
                //SelectedRegio = MvcMovie.Request.CreateList("83599NED/RegioS"),
                SelectedPerioden = MvcMovie.Request.CreateList("81487ned/Perioden"), 
                SelectedKenmerkenwerknemer = MvcMovie.Request.CreateList("81487ned/KenmerkenWerknemer?$filter=Key eq '3000 ' or Key eq '4000 ' or Key eq '70400' or Key eq '70500' or Key eq '70600' or Key eq '70700' or Key eq '70800'"),
                //SelectedKenmerkenwerknemer2 = MvcMovie.Request.CreateList("81487ned/KenmerkenWerknemer?$filter=Key eq '10000' or Key eq '3000 ' or Key eq '4000 '"),
                SelectedCoasector = MvcMovie.Request.CreateList("81487ned/CaoSector"),
                SelectedCriteria = MvcMovie.Request.CreateList("81487ned/DataProperties?$select=Key,Title,Description&$filter=Key eq 'Minimumloon_2' or Key eq 'TotaalBanen_1' or Key eq 'TotaalArbeidsvolume_8'"),
                //SelectedOnderwijsvolgend = MvcMovie.Request.CreateList("82915NED/Onderwijsvolgend")
            };
            ViewData["Filters"] = filters; 
            return View();
        }
    }
}