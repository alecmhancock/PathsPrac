using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathsPrac
{
    public class Geocode
    {
        [JsonProperty("SAME")]
        public List<string> SAME { get; set; }

        [JsonProperty("UGC")]
        public List<string> UGC { get; set; }
    }
    public class Parameters
    {
        [JsonProperty("AWIPSidentifier")]
        public List<string> AWIPSidentifier { get; set; }

        [JsonProperty("WMOidentifier")]
        public List<string> WMOidentifier { get; set; }

        [JsonProperty("NWSheadline")]
        public List<string> NWSheadline { get; set; }

        [JsonProperty("eventMotionDescription")]
        public List<string> eventMotionDescription { get; set; }

        [JsonProperty("maxWindGust")]
        public List<string> maxWindGust { get; set; }

        [JsonProperty("maxHailSize")]
        public List<string> maxHailSize { get; set; }

        [JsonProperty("BLOCKCHANNEL")]
        public List<string> BLOCKCHANNEL { get; set; }

        [JsonProperty("EAS-ORG")]
        public List<string> EASORG { get; set; }

        [JsonProperty("tornadoDetection")]
        public List<string> tornadoDetection { get; set; }

        [JsonProperty("VTEC")]
        public List<string> VTEC { get; set; }

        [JsonProperty("eventEndingTime")]
        public List<DateTime> eventEndingTime { get; set; }

        [JsonProperty("expiredReferences")]
        public List<string> expiredReferences { get; set; }
    }
    public class Reference
    {
        [JsonProperty("@id")]
        public string id { get; set; }

        [JsonProperty("identifier")]
        public string identifier { get; set; }

        [JsonProperty("sender")]
        public string sender { get; set; }

        [JsonProperty("sent")]
        public DateTime sent { get; set; }
    }

    public class Root
    {
        [JsonProperty("@context")]
        public List<object> context { get; set; }

        [JsonProperty("type")]
        public string type { get; set; }

        [JsonProperty("features")]
        public List<Feature> features { get; set; }

        [JsonProperty("title")]
        public string title { get; set; }

        [JsonProperty("updated")]
        public DateTime updated { get; set; }
    }








}
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

