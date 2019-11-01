using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class ClassBase
    {
        [JsonProperty("href")]
        public string href { get; set; }
        [JsonProperty("title")]
        public string title { get; set; }
    }
}
