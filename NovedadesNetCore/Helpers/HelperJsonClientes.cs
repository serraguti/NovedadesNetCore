using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
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

        //DEBEMOS PONER EL NAMESPACE COMPLETO, YA QUE System.Text.Json TIENE 
        //CLASES QUE SE LLAMAN IGUAL A LAS DE NEWTON
        public List<Cliente> GetClientesMicrosoft()
        {
            var options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
            List<Cliente> clientes = 
                System.Text.Json.JsonSerializer.Deserialize<List<Cliente>>(this.jsonClientes, options);
            return clientes;
        }
    }
}
