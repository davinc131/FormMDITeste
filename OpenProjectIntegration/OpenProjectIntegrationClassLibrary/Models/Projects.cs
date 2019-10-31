using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class Projects
    {
        public string _type { get; set; }
        public int total { get; set; }
        public int count { get; set; }
        [JsonProperty("_embedded.elements")]
        public List<Project> _embedded { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime updatedAt { get; set; }
    }
}
