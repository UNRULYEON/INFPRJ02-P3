using System;
using System.Net.Http;

namespace WebAPIClient
{
    class Program
    {
        public static Root GenerateFromJson(string api, string queryoption)
        {
            var url = api + "?" + queryoption;
            using (var clientjs = new HttpClient())
            {
                HttpResponseMessage responseJson = clientjs.GetAsync(url).Result;  
                responseJson.EnsureSuccessStatusCode();
                var responseBody = responseJson.Content.ReadAsStringAsync().Result;
                var temp = Value.FromJson(responseBody);
                HttpResponseMessage leeftijdJson =
                    clientjs.GetAsync("https://opendata.cbs.nl/ODataApi/OData/82809NED/Leeftijd").Result;
                leeftijdJson.EnsureSuccessStatusCode();
                var leeftijdBody = leeftijdJson.Content.ReadAsStringAsync().Result;
                var tmpleeftijd = Value.FromJson(leeftijdBody);
                foreach (var entry in temp.Value)
                {
                    entry.Leeftijd = ConvertToString(entry.Leeftijd.ToString(), tmpleeftijd);
                    entry.Geslacht = ConvertValue(entry.Geslacht);
                    entry.Migratieachtergrond = ConvertValue(entry.Migratieachtergrond);
                }

                return temp;
            }
        }
        static void Main(string[] args)
        {
            var welcome = GenerateFromJson("https://opendata.cbs.nl/ODataApi/OData/82809NED/TypedDataSet","$top=100&$filter=Migratieachtergrond eq '2012657' or Migratieachtergrond eq '2012655'");
            foreach (var entry in welcome.Value)
            {   
                Console.WriteLine(entry.Id.ToString());
                Console.WriteLine(entry.Geslacht);
                Console.WriteLine(entry.Migratieachtergrond);
                Console.WriteLine(entry.Leeftijd);
                Console.WriteLine("\n");
            }

        }

        private static string ConvertToString(string value, Root leeftijd)
        {
            foreach (var entry in leeftijd.Value)
            {
                if (value == entry.Key)
                    return entry.Title;
            }
            return null;
        }
        private static string ConvertValue(string gender)
        {
            switch (gender)
            {
                case "T001038": return "Mannen en Vrouwen";
                case "3000   ": return "Mannen";
                case "4000   ": return "Vrouwen";
                case "T001040": return "Totaal ";
                case "2012605": return "Met migratieachtergrond";
                case "2012655": return "Westerse migratieachtergrond";
                case "2012657": return "Niet-westerse migratieachtergrond";
                default: return null;
            }
        }
    }
}