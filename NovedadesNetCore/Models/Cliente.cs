using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Models
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string PaginaWeb { get; set; }
        public string ImagenCliente { get; set; }
    }
}
