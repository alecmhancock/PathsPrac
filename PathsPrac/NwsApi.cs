using BAMCIS.GeoJSON;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PathsPrac
{
    public class NwsApi
    {
        private HttpClient _client;

        public NwsApi(HttpClient client)
        {
            _client = client;
        }

       
        public string GetJsonString(string url)
        {
            var response = _client.GetAsync(url).Result;
            var json = response.Content.ReadAsStringAsync().Result;
            return json;
        }
        
        

    }
}
