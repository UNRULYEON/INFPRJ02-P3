using System.Collections.Generic;
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
                string gender = "$filter=Geslacht eq " + "'" + filter.Gender + "'";
                string background = "$filter=Migratieachtergrond eq " + "'" + filter.MigratieAchtergrond + "'";
                string period = "$filter=Perioden eq " + "'" + filter.Period + "'";
                var migratie = MvcMovie.Request.GenerateFromJson(
                    "https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet",
                    "$top=1000&" + age + "&" + gender + "&" + background + "&" + period);
                ViewData["migratie"] = migratie;
                List<string> mValues = new List<string>();
                List<string> mLabel = new List<string>();
                foreach (var entry in migratie.Value)
                {
                    mLabel.Add(entry.Geslacht);
                    mValues.Add(entry.Werknemer4.ToString());
                }
                ViewBag.Val = mValues;
                ViewBag.Lab = mLabel;
            }
            var filters = new FilterOptions
            {
                SelectedAge = MvcMovie.Request.CreateList("82809NED/Leeftijd"),
                SelectedGender = MvcMovie.Request.CreateList("82809NED/Geslacht"),
                SelectedMigratieAchtergrond = MvcMovie.Request.CreateList("82809NED/Migratieachtergrond"),
                SelectedPeriod = MvcMovie.Request.CreateList("82809NED/Perioden")
            };
            ViewData["Filters"] = filters;
            return View();
        }
    }
}