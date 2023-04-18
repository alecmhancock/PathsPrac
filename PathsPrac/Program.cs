using Newtonsoft.Json;
using PathsPrac.Classes;
using System.Net.Http.Headers;
using PathsPrac;

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
foreach (var props in Properties.features)
{
    if (props.properties.expires < currentTime || props.properties.headline == null || props.properties.@event == "Test Message")
    {
        continue;
    }
    if (props.geometry == null)
    {
        continue;
    }
    if (props.properties.@event == "Severe Thunderstorm Warning" || props.properties.@event == "Tornado Warning" || props.properties.@event == "Special Weather Statement")
    {

        Console.WriteLine(props.properties.headline);
        Console.WriteLine(props.id);
        Console.WriteLine($"Expires {props.properties.expires}");
        Console.WriteLine($"Areas affected: {props.properties.areaDesc}");
        Console.WriteLine(props.properties.description);
        Console.WriteLine();
        
        foreach (var list1 in props.geometry.coordinates)
        {
            foreach (var list2 in list1)
            {
                foreach (var coords in list2)
                {
                    
                }
                Console.WriteLine();
            }
           

            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            


        }



    }
}
