using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Services
{
    public class BreakString
    {
        public static string[] BreakStringValue(string value)
        {
            string[] breakString = value.Split('/');
            return breakString;
        }
    }
}
