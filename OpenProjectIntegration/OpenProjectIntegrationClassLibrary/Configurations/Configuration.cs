using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Configurations
{
    public class Configuration
    {
        public string ProjectId { get; set; }
        public string TypeId { get; set; }
        public string UserId { get; set; }
        public string AccessToken { get; set; }
        public Uri StringUri { get; set; }

        public Configuration(string projectId, string typeId, string userId, string accessToken, Uri stringUri)
        {
            this.ProjectId = projectId;
            this.TypeId = typeId;
            this.UserId = userId;
            this.AccessToken = accessToken;
            this.StringUri = stringUri;
        }
    }
}
