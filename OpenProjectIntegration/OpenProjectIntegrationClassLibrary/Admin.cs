using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;

namespace OpenProjectIntegrationClassLibrary
{
    public partial class Admin
    {
        //[YamlMember(Alias = "default")]
        //public bool Default { get; set; }

        //[YamlMember(Alias = "permissions")]
        //public string[] Permissions { get; set; }

        //[YamlMember(Alias = "inheritance")]
        //public string[] Inheritance { get; set; }

        //[YamlMember(Alias = "info")]
        //public Info Info { get; set; }

        //[YamlMember(Alias = "log_level")]
        //public string Log_level { get; set; }

        [YamlMember(Alias = "global_basic_auth")]
        public string[] Global_basic_auth { get; set; }

        //[YamlMember(Alias = "disable_password_choice")]
        //public bool Disable_password_choice { get; set; }

        //[YamlMember(Alias = "session_store")]
        //public string Session_store { get; set; }

        //[YamlMember(Alias = "rails_force_ssl")]
        //public string Rails_force_ssl { get; set; }

        //[YamlMember(Alias = "email_delivery_method")]
        //public string Email_delivery_method { get; set; }
    }
}
