using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace NovedadesNetCore.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string PaginaWeb { get; set; }
        //[JsonProperty("imagencliente")]
        public string ImagenCliente { get; set; }
    }
}
