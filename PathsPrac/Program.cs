using Newtonsoft.Json;
using PathsPrac;
using System.Net.Http.Headers;
using System.Linq;

#region Web client params
var client = new HttpClient();
var productValue = new ProductInfoHeaderValue("PathsWX", "Alpha");
client.DefaultRequestHeaders.UserAgent.Add(productValue);
var response = new NwsApi(client);
var url = "https://api.weather.gov/alerts/active/";
var json = response.GetJsonString(url);
#endregion

#region Time declarations for expiration filter
var currentTime = DateTime.Now;
var timeString = currentTime.ToString("MM/dd/yyyy HH:mm:ss tt");
Console.WriteLine(timeString);
Console.WriteLine();
#endregion

Root Properties = JsonConvert.DeserializeObject<Root>(json);
Root Geometry = JsonConvert.DeserializeObject<Root>(json);
var idList = new List<string>();
foreach (var props in Properties.features)
{
    if (props.properties.expires < currentTime || props.properties.headline == null)
    {
        continue;
    }
    if (props.properties.@event == "Severe Thunderstorm Warning" || props.properties.@event == "Tornado Warning" || props.properties.@event == "Special Weather Statement")
    {
        Console.WriteLine(props.properties.headline);
        Console.WriteLine(props.properties.id);
        Console.WriteLine($"Expires {props.properties.expires}");
        Console.WriteLine($"Areas affected: {props.properties.areaDesc}");
        Console.WriteLine(props.properties.description);
        idList.Add(props.properties.id);
        Console.WriteLine("\n");


    }

    //THIS IS YOUR TODO, GET THE COORDINATES WORKING YOU MORON

    //foreach (var geo in Geometry.features)
    //{
    //    if (idList.Contains(geo.properties.@id))
    //    {
    //        foreach(var coord in geo.geometry.coordinates)
    //        {
    //            Console.WriteLine(coord.ToString());
    //        }
    //    }
    //}
}

