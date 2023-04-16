using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsPrac
{
    public class Properties
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("@type")]
        public string type { get; set; }

        [JsonProperty("areaDesc")]
        public string areaDesc { get; set; }

        [JsonProperty("geocode")]
        public Geocode geocode { get; set; }

        [JsonProperty("affectedZones")]
        public List<string> affectedZones { get; set; }

        [JsonProperty("references")]
        public List<Reference> references { get; set; }

        [JsonProperty("sent")]
        public DateTime sent { get; set; }

        [JsonProperty("effective")]
        public DateTime effective { get; set; }

        [JsonProperty("onset")]
        public DateTime? onset { get; set; }

        [JsonProperty("expires")]
        public DateTime expires { get; set; }

        [JsonProperty("ends")]
        public DateTime? ends { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("messageType")]
        public string messageType { get; set; }

        [JsonProperty("category")]
        public string category { get; set; }

        [JsonProperty("severity")]
        public string severity { get; set; }

        [JsonProperty("certainty")]
        public string certainty { get; set; }

        [JsonProperty("urgency")]
        public string urgency { get; set; }

        [JsonProperty("event")]
        public string @event { get; set; }

        [JsonProperty("sender")]
        public string sender { get; set; }

        [JsonProperty("senderName")]
        public string senderName { get; set; }

        [JsonProperty("headline")]
        public string headline { get; set; }

        [JsonProperty("description")]
        public string description { get; set; }

        [JsonProperty("instruction")]
        public string instruction { get; set; }

        [JsonProperty("response")]
        public string response { get; set; }

        [JsonProperty("parameters")]
        public Parameters parameters { get; set; }
    }
}
