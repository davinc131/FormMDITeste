using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class Activity
    {
        [JsonProperty("_type")]
        public string _type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("version")]
        public int version { get; set; }
        [JsonProperty("comment")]
        public Description comment { get; set; }
        [JsonProperty("createdAt")]
        public DateTime createdAt { get; set; }
        [JsonProperty("_links.user")]
        public ClassBase user { get; set; }
    }
}
