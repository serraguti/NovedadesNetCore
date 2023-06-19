using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Models
{
    public class Deportivo
    {
        public Deportivo()
        {
            this.Marca = "Lamborguini";
            this.Modelo = "Diablo";
            this.Velocidad = 0;
        }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Velocidad { get; set; }

        public void Acelerar()
        {
            this.Velocidad += 60;
        }

        public void Frenar()
        {
            this.Velocidad -= 60;
        }
    }
}
