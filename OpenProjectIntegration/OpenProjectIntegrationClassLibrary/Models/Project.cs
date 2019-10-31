using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class Project
    {
        public string _type { get; set; }
        public int id { get; set; }
        public string identifer { get; set; }
        public string name { get; set; }
        [JsonProperty("public")]
        public bool Public{get; set;}
        [JsonProperty("description")]
        public Description description { get; set; }
    }
}
