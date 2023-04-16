using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsPrac
{
    public class Feature
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("geometry")]
        public Geometry geometry { get; set; }

        [JsonProperty("properties")]
        public Properties properties { get; set; }


    }
}
