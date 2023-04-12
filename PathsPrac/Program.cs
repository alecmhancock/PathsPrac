using Newtonsoft.Json.Linq;
using PathsPrac;
using System.Net.Http;
using System.Net.Http.Headers;
using BAMCIS.GeoJSON;
using System.Linq;
using System.Collections.Generic;
using BAMCIS.GeoJSON.Serde;

var client = new HttpClient();
var productValue = new ProductInfoHeaderValue("PathsWX", "Alpha");
client.DefaultRequestHeaders.UserAgent.Add(productValue);
var response = new PathsPrac.NwsApi(client);
#region coord parsing
List<string> coords = new List<string>();
var warningText = "LAT...LON 3036 9309 3029 9303 3014 9328 3017 9335 3035 9332";
List<string> warningList = warningText.Split(" ").ToList();
foreach (var item in warningList)
{
    if (item.Contains("LAT...LON"))
    {
        continue;
    }
    else
    {
        var itemInt = Convert.ToDouble(item);
        var coord = itemInt / 100;
        coords.Add(coord.ToString());
    }
}
#endregion

Console.WriteLine(response.GetActiveAlertsBMX());