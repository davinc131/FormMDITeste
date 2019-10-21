using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenProjectIntegrationClassLibrary
{
    public class Security
    {
        [YamlMember(Alias = "groups")]
        public Groups Groups { get; set; }
    }
}
