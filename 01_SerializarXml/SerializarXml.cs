using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace FormMDITeste._01_SerializarXml
{
    public class SerializarXml
    {
        public SerializarXml()
        {
            //Serializer();
        }

        public void Serializer()
        {
            Usuario usuario = new Usuario() { Nome = "Carlos Eduardo e Silva", CPF = "35212498552", Email = "carlos123@gmail.com" };
            StreamWriter streamWriter = new StreamWriter(@"C:\Users\USER-23\Documents\Arquivos C#\01_Serializar.xml");
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            serializador.Serialize(streamWriter, usuario);
        }

        public Usuario Deserializer()
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\USER-23\Documents\Arquivos C#\01_Serializar.xml");
            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            
            return (Usuario)serializador.Deserialize(streamReader);
        }
    }
}
