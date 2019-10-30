using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Models
{
    public class User
    {
        public string type { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public TimeSpan createdAt { get; set; }
        public TimeSpan updatedAt { get; set; }
        public string login { get; set; }
        public bool admin { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string avatar { get; set; }
        public string status { get; set; }
        public Uri identityUrl { get; set; }
    }
}
