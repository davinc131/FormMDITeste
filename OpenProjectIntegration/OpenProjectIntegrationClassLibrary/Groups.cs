using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenProjectIntegrationClassLibrary
{
    public partial class Groups
    {
        [YamlMember(Alias = "default")]
        public Admin Default { get; set; }

        [YamlMember(Alias = "authentication")]
        public Admin Authentication { get; set; }

        //[YamlMember(Alias = "production")]
        //public Admin Production { get; set; }

        //[YamlMember(Alias = "development")]
        //public Admin Development { get; set; }
    }
}
