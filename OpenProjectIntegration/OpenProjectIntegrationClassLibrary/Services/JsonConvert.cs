using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace OpenProjectIntegrationClassLibrary.Services
{
    public class JsonConvert
    {
        public static string SerializeObject<T>(T t)
        {
            try
            {
                JavaScriptSerializer serializeObject = new JavaScriptSerializer();
                return serializeObject.Serialize(t);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static T DeserializeObject<T>(string json)
        {
            try
            {
                JavaScriptSerializer desserializeObject = new JavaScriptSerializer();
                return desserializeObject.Deserialize<T>(json);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static string ConverteObjectParaJSon<T>(T obj)
        {
            try
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream();
                ser.WriteObject(ms, obj);
                string jsonString = Encoding.UTF8.GetString(ms.ToArray());
                ms.Close();
                return jsonString;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static T ConverteJSonParaObject<T>(string jsonString)
        {
            try
            {
                DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
                MemoryStream ms = new MemoryStream(Encoding.UTF8.GetBytes(jsonString));
                T obj = (T)serializer.ReadObject(ms);
                return obj;
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
