using NovedadesNetCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NovedadesNetCore.Helpers
{
    public class HelperLambda
    {
        private List<Persona> personasList;
        private List<int> numerosList;

        public HelperLambda()
        {
            this.numerosList = new List<int>();
            for (int i = 1; i <= 50; i++)
            {
                this.numerosList.Add(i);
            }

            this.personasList = new List<Persona>
            {
                new Persona {IdPersona = 1, Nombre = "Lucia", Email= "lucia@gmail.com", Edad=21},
                new Persona {IdPersona = 2, Nombre = "Adrian", Email= "adrian@gmail.com", Edad=25},
                new Persona {IdPersona = 3, Nombre = "Carlos", Email= "carlos@gmail.com", Edad=28},
                new Persona {IdPersona = 4, Nombre = "Antonia", Email= "antonia@gmail.com", Edad=51},
                new Persona {IdPersona = 5, Nombre = "Diana", Email= "diana@gmail.com", Edad=31},
                new Persona {IdPersona = 6, Nombre = "Pedro", Email= "pedro@gmail.com", Edad=11}
            };
        }

        //METODO TRADICIONAL CON SKIP Y TAKE
        public List<int> GetElementosPaginados()
        {
            var datos = this.numerosList.Skip(0).Take(10).ToList();
            return datos;
        }


        public List<Persona> GetPersonas()
        {
            return this.personasList;
        }

        public List<Persona> GetPersonasEdad()
        {
            List<Persona> outputList = new List<Persona>();
            foreach (Persona p in this.personasList)
            {
                if (p.Edad >= 20 && p.Edad <= 30)
                {
                    outputList.Add(p);
                }
            }
            return outputList;
        }

        public List<Persona> GetPersonasEdadLambda(int edadInicial, int edadFinal)
        {
            List<Persona> outputList =
                this.personasList.Where(x => x.Edad >= edadInicial && x.Edad <= edadFinal).ToList();
            return outputList;
        }

        public List<Persona> GetPersonasPatronPropiedades() // (int edadInicial, int edadFinal)
        {
            List<Persona> outputList =
                this.personasList.FindAll(p => p is
                {
                    Edad: >= 20,
                    Edad: <= 30, 
                    Email.Length: > 0
                });
            return outputList;
        }
    }
}
