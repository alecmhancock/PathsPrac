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

        public string GetActiveAlertsBMX()
        {
            var response = _client.GetAsync("https://api.weather.gov/alerts/active?area=AL").Result;
            var responseString = response.Content.ReadAsStringAsync().Result;
            return responseString;
        }



    }
}
