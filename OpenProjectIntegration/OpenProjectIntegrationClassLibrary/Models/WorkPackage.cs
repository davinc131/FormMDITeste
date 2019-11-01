using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class WorkPackage
    {
        //public string spenTime { get; set; }
        //public string laborCosts { get; set; }
        //public string materialCosts { get; set; }
        [JsonProperty("_type")]
        public string _type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("lockVersion")]
        public int lockVersion { get; set; }
        [JsonProperty("subject")]
        public string subject { get; set; }
        [JsonProperty("description")]
        public Description description { get; set; }
        //public DateTime startDate { get; set; }
        //public DateTime dueDate { get; set; }
        [JsonProperty("date")]
        public string date { get; set; }
        [JsonProperty("estimatedDate")]
        public string estimatedDate { get; set; }
        [JsonProperty("derivedEstimatedDate")]
        public string derivedEstimatedDate { get; set; }
        [JsonProperty("percentageDone")]
        public int percentageDone { get; set; }
        [JsonProperty("createdAt")]
        public DateTime createdAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime updatedAt { get; set; }
        //public DateTime remainingTime { get; }
        [JsonProperty("_links.author")]
        public ClassBase author { get; set; }
        [JsonProperty("_links.type")]
        public ClassBase type { get; set; }
        [JsonProperty("_links.activities")]
        public ClassBase activities { get; set; }
        public List<Activity> Activity { get; set; }
    }
}
