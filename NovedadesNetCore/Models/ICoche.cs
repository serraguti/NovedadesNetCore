using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Models
{
    public interface ICoche
    {
        string Marca { get; set; }
        string Modelo { get; set; }
        int Velocidad { get; set; }
        void Acelerar();
        void Frenar();
    }
}
