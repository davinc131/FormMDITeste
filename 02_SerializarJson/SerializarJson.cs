using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;
using System.IO;

namespace FormMDITeste._02_SerializarJson
{
    public class SerializarJson
    {
        public void Serializar()
        {
            Usuario usuario = new Usuario() { Nome = "Marcos Eduardo e Silva", CPF = "66612498552", Email = "marcos123@gmail.com" };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializer = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(@"../openproject_brgaap.json");
            sw.WriteLine(stringObjSerializer);
            sw.Close();
        }

        public Usuario Deserializar()
        {
            StreamReader streamReader = new StreamReader(@"../openproject_brgaap.json");
            string textJson = streamReader.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario =  (Usuario)serializador.Deserialize(textJson, typeof(Usuario));

            return usuario;
        }

    }
}
