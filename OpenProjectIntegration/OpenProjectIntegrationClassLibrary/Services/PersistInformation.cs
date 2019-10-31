using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenProjectIntegrationClassLibrary.Services
{
    public class PersistInformation
    {
        public void RecordFile(string jsonString)
        {
            StreamWriter sw = new StreamWriter(@"../openproject_brgaap.json");
            sw.WriteLine(jsonString);
            sw.Close();
        }

        public string ReadFile()
        {
            StreamReader streamReader = new StreamReader(@"../openproject_brgaap.json");
            string textJson = streamReader.ReadToEnd();
            return textJson;    
        }
    }
}
