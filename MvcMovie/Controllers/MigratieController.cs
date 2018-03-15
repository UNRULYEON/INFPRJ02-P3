using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Server.Kestrel.Transport.Libuv.Internal.Networking;
using Microsoft.WindowsAzure.Storage.File;
using Models;

namespace MvcMovie
{
    public class MigratieController : Controller
    {
        public IActionResult Index(FilterOptions filter)
        {
            if (filter != null)
            {
                string s = "$filter=Leeftijd eq " + "'" + filter.Age + "'";
                string t = "$filter=Geslacht eq " + "'" + filter.Gender + "'";
                string m = "$filter=Migratieachtergrond eq " + "'" + filter.MigratieAchtergrond + "'";
                var migratie = MvcMovie.Request.GenerateFromJson(
                    "https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet",
                    "$top=1000&" + s + "&" + t + "&" + m);
                ViewData["migratie"] = migratie;
            }
            var filters = new FilterOptions();
            filters.SelectedAge = MvcMovie.Request.CreateList("82809NED/Leeftijd");
            filters.SelectedGender = MvcMovie.Request.CreateList("82809NED/Geslacht");
            filters.SelectedMigratieAchtergrond = MvcMovie.Request.CreateList("82809NED/Migratieachtergrond");
            ViewData["Filters"] = filters;
            return View();
        }
    }
}