using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore
{
    public class CocheController
    {
        private Coche car;

        public CocheController(Coche car)
        {
            this.car = car;
        }

        public string DescripcionCoche()
        {
            return this.car.Marca + " " + this.car.Modelo;
        }

        public string AcelerarCoche()
        {
            this.car.Acelerar();
            return "La velocidad del coche es " + this.car.Velocidad + " km/h";
        }

        public string FrenarCoche()
        {
            this.car.Frenar();
            return "La velocidad del coche es " + this.car.Velocidad + " km/h";
        }
    }
}
