using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class User
    {
        [JsonProperty("_type")]
        public string type { get; set; }
        [JsonProperty("id")]
        public int id { get; set; }
        [JsonProperty("name")]
        public string name { get; set; }
        [JsonProperty("createdAt")]
        public DateTime createdAt { get; set; }
        [JsonProperty("updatedAt")]
        public DateTime updatedAt { get; set; }
        [JsonProperty("login")]
        public string login { get; set; }
        [JsonProperty("admin")]
        public bool admin { get; set; }
        [JsonProperty("firstName")]
        public string firstName { get; set; }
        [JsonProperty("lastName")]
        public string lastName { get; set; }
        [JsonProperty("email")]
        public string email { get; set; }
        [JsonProperty("avatar")]
        public string avatar { get; set; }
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("identityUrl")]
        public Uri identityUrl { get; set; }
        [JsonProperty("_links")]
        public Links _links { get; set; }
    }
}
