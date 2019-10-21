using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSCorreios
{
    public class ServiceCorreios
    {
        public WSCep.enderecoERP BuscarEndereco(string cep)
        {
            using (var ws = new WSCep.AtendeClienteClient())
            {
                var endereco = ws.consultaCEP(cep);
                return endereco;
            } 
        }
    }
}
