using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Models;

namespace MvcMovie
{
    public class Request
    {
            public static Root GenerateFromJson(string api, string queryoption)
            {
                var url = api + "?" + queryoption;
                var temp =                           GetRequest(url);
                var leeftijd =                       GetRequest("https://opendata.cbs.nl/ODataApi/OData/82809NED/Leeftijd");
                var geslacht =                       GetRequest("https://opendata.cbs.nl/ODataApi/OData/82809NED/Geslacht");
                var migratieachtergrond =            GetRequest("https://opendata.cbs.nl/ODataApi/OData/82809NED/Migratieachtergrond");
                foreach (var entry in temp.Value)
                {
                    entry.Leeftijd =                 ConvertToString(leeftijd,entry.Leeftijd);
                    entry.Geslacht =                 ConvertToString(geslacht,entry.Geslacht);
                    entry.Migratieachtergrond =      ConvertToString(migratieachtergrond,entry.Migratieachtergrond);
                    //entry.Units =                toDictionary(entry,dataproperties,entry.Beroepsbevolking2);
                    //var welcome = GenerateFromJson("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet","$top=100&$filter=Migratieachtergrond eq '2012657' or Migratieachtergrond eq '2012655'");

                }
                return temp;
            }
            private static string ConvertToString(Root root, string target)
            {
                foreach (var entry in root.Value)
                {
                    if (target == entry.Key)
                        return entry.Title;
                }
                return null;
            }

        public static List<SelectListItem> CreateList(string source)
        {
            var root = GetRequest("https://opendata.cbs.nl/ODataApi/OData/" + source);
            var temp = new List<SelectListItem>();
            foreach (var entry in root.Value)
            {
                temp.Add(new SelectListItem{ Text = entry.Title, Value = entry.Key});
            }
            return temp;
        }
            public static Root GetRequest(string url)
            {
                var client = new HttpClient();
                HttpResponseMessage responseJson = client.GetAsync(url).Result;  
                responseJson.EnsureSuccessStatusCode();
                var responseBody = responseJson.Content.ReadAsStringAsync().Result;
                return Value.FromJson(responseBody);
            }
    }
}