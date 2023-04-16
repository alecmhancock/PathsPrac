using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsPrac
{
    public class Geometry
    {
        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("coordinates")]
        public List<List<List<double>>> coordinates { get; set; }
    }
}
