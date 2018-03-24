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
                string age = "$filter=Leeftijd eq " + "'" + filter.Age + "'";
                string gender = "Geslacht eq " + "'" + filter.Gender + "'";
                string background = "Migratieachtergrond eq " + "'" + filter.MigratieAchtergrond + "'";
                string background2 = "Migratieachtergrond eq " + "'" + filter.MigratieAchtergrond2 + "'";
                string period = "Perioden eq " + "'" + filter.Period + "'";
                //var migratie = "https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?$top=1000&" + age + " and " + gender + " and " + background + " and " + period;
                ViewData["root"] = "https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?";
                ViewData["age"] = filter.Age;
                ViewData["gender"] = filter.Gender;
                ViewData["background"] = filter.MigratieAchtergrond;
                ViewData["background2"] = filter.MigratieAchtergrond2;
                ViewData["period"] = filter.Period;
               /* var migratie2 = HttpUtility.HtmlEncode("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet?$top=1000&" + age + " and " + gender + " and " + background2 + " and " + period);
                ViewData["migratie"] = migratie;
                ViewData["migratie2"] = migratie2;
                ViewBag.Mig = migratie;*/
            }
            var filters = new FilterOptions
            {
                SelectedAge = MvcMovie.Request.CreateList("82809NED/Leeftijd"),
                SelectedGender = MvcMovie.Request.CreateList("82809NED/Geslacht"),
                SelectedMigratieAchtergrond = MvcMovie.Request.CreateList("82809NED/Migratieachtergrond?$filter=Key eq '2012657' or Key eq '2012655' or Key eq '2012605' or Key eq '1012600' or Key eq 'T001040'"),
                SelectedPeriod = MvcMovie.Request.CreateList("82809NED/Perioden?$filter=endswith(Title,'kwartaal') eq false"),
                SelectedCriteria = MvcMovie.Request.CreateList("82809NED/DataProperties?$select=Key,Title,Description&$filter=Key eq 'Beroepsbevolking_2' or Key eq 'Werknemer_4' or Key eq 'WerklozeBeroepsbevolking_20'")
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}