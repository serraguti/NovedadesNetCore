using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Models
{
    public class Coche
    {
        public Coche()
        {
            this.Marca = "Batmovil";
            this.Modelo = "Nolan";
            this.Velocidad = 0;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidad { get; set; }

        public void Acelerar()
        {
            this.Velocidad += 20;
        }

        public void Frenar()
        {
            this.Velocidad -= 20;
        }
    }
}
