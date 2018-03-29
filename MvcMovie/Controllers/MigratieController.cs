using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using Microsoft.WindowsAzure.Storage.File;
using Newtonsoft.Json;
using Models;

namespace MvcMovie
{
    public class MigratieController : Controller
    {
        public IActionResult Index(FilterOptions filter)
        {
            if (filter != null)
            {
                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/odata/82809NED/TypedDataSet?";
            }
            var filters = new FilterOptions
            {
                SelectedAge = MvcMovie.Request.CreateList("82809NED/Leeftijd"),
                SelectedGender = MvcMovie.Request.CreateList("82809NED/Geslacht"),
                SelectedMigratieAchtergrond = MvcMovie.Request.CreateList("82809NED/Migratieachtergrond?$filter=Key " +
                                                                          "eq '2012657' or Key eq '2012655' or Key " +
                                                                          "eq '2012605' or Key eq '1012600' or " +
                                                                          "Key eq 'T001040'"),
                SelectedPeriod = MvcMovie.Request.CreateList("82809NED/Perioden?$filter=endswith(Title,'kwartaal') " +
                                                             "eq false"),
                SelectedCriteria = MvcMovie.Request.CreateList("82809NED/DataProperties?$select=Key,Title,Description&" +
                                                               "$filter=Key eq 'Beroepsbevolking_2' or Key eq " +
                                                               "'Werknemer_4' or Key eq 'WerklozeBeroepsbevolking_20'")
            };
            ViewData["Description"] = MvcMovie.Request.CreateDisc(
                "82809NED/DataProperties?$select=Key,Title,Description&" +
                "$filter=Key eq 'Beroepsbevolking_2' or Key eq " +
                "'Werknemer_4' or Key eq 'WerklozeBeroepsbevolking_20'");
            ViewData["Filters"] = filters;
            return View();
        }
    }
}