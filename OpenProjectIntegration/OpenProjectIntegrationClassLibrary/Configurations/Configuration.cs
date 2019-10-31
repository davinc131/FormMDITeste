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
        public UserSystem UserSystem { get; set; }
        public Uri StringUri { get; set; }

        public Configuration(string projectId, string typeId, UserSystem userSystem, Uri stringUri)
        {
            this.ProjectId = projectId;
            this.TypeId = typeId;
            this.UserSystem = userSystem;
            this.StringUri = stringUri;
        }

        public Configuration(string projectId, string typeId, Uri stringUri)
        {
            this.ProjectId = projectId;
            this.StringUri = stringUri;
            this.TypeId = typeId;
        }

        public Configuration(UserSystem userSystem)
        {
            this.UserSystem = userSystem;
        }
    }
}
