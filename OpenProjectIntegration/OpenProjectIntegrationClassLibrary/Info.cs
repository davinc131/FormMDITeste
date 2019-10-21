using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenProjectIntegrationClassLibrary
{
    public partial class Info
    {
        [YamlMember(Alias = "prefix")]
        public string Prefix { get; set; }

        [YamlMember(Alias = "build")]
        public bool Build { get; set; }

        [YamlMember(Alias = "suffix")]
        public string Suffix { get; set; }
    }
}
