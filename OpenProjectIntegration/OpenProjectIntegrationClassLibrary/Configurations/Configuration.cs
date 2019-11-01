using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Configurations
{
    public class Configuration
    {
        public int ConfigurationsId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string TypeId { get; set; }
        public Uri StringUri { get; set; }

        public Configuration(string projectName, Uri stringUri)
        {
            this.ProjectName = projectName;
            this.StringUri = stringUri;
        }

        public Configuration(int projectId, Uri stringUri, string typeId = null)
        {
            this.ProjectId = projectId;
            this.TypeId = typeId;
            this.StringUri = stringUri;
        }
    }
}
