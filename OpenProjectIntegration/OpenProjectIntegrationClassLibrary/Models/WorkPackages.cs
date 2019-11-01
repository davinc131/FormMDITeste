using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class WorkPackages
    {
        public string _type { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        public int pageSize { get; set; }
        public int offset { get; set; }
        [JsonProperty("_embedded.elements")]
        public List<WorkPackage> _embedded { get; set; }
    }
}
