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
                //string KenmerkenBaanBedrijfsgrootte = "$filter=KenmerkenBaanBedrijfsgrootte eq " + "'" + filter.KenmerkenBaanBedrijfsgrootte +  "'";
                string Perioden = "Perioden eq " + "'" + filter.Perioden + "'";

                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/odata/81405ned/TypedDataSet?";
                ViewData["KenmerkenBaanBedrijfsgrootte"] = filter.KenmerkenBaanBedrijfsgrootte;
                ViewData["Perioden"] = filter.Perioden;
            }
            var filters = new Deelvraag2FilterOptions()
            {
                selectedBedrijfstakkenBranchesSBI2008 = MvcMovie.Request.CreateList("81405ned/BedrijfstakkenBranchesSBI2008?$filter=Key eq '300035' or Key eq '391600' or Key eq '300010' or Key eq '419000' or Key eq '422400'"),
                selectedKenmerkenBaanBedrijfsgrootte = MvcMovie.Request.CreateList("81405ned/KenmerkenBaanBedrijfsgrootte?$filter=Key%20eq%20%2710000%27%20or%20Key%20eq%20%2721260%27%20or%20Key%20eq%20%2721250%27%20or%20Key%20eq%20%2721210%27 or Key eq '21260' or Key eq '21250' or Key eq '601  ' or Key eq '602  ' or Key eq '604  ' or Key eq '20360' or Key eq '20240'"),
                selectedPerioden = MvcMovie.Request.CreateList("81405ned/Perioden"),
                selectedCritters = MvcMovie.Request.CreateList("81405ned/DataProperties?select=Key,Title,Description&$filter=Key eq 'Minimumloon_2' or Key eq 'TotaalArbeidsvolume_8' or Key eq 'TotaalBanen_1' or Key eq 'Minimumloon_9'")
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}
