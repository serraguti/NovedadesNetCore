using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Helpers
{
    public class HelperJsonClientes
    {
        private string jsonClientes;
        public HelperJsonClientes()
        {
            //UN RECURSO INCRUSTADO SE RECUPERA CON EL NAMESPACE Y LA UBICACION
            string path = "NovedadesNetCore.Documents.clientes.json";
            Stream stream = this.GetType().Assembly.GetManifestResourceStream(path);
            StreamReader reader = new StreamReader(stream);
            this.jsonClientes = reader.ReadToEnd();
        }

        //VAMOS A CONVERTIR EL JSON A CLASES
        public List<Cliente> GetClientesNewton()
        {
            List<Cliente> clientes =
                JsonConvert.DeserializeObject<List<Cliente>>(this.jsonClientes);
            return clientes;
        }
    }
}
