using NovedadesNetCore.Helpers;
using NovedadesNetCore.Models;
using System.Runtime.CompilerServices;

Console.WriteLine("Ejemplo novedades");
Console.WriteLine("Lambda");
HelperLambda helperLambda = new HelperLambda();
List<Persona> personas = helperLambda.GetPersonas();
foreach (Persona p in personas)
{
    Console.WriteLine(p.IdPersona + " - " + p.Nombre);
}
Console.WriteLine("Filtrando por edad");
List<Persona> personasFiltro = helperLambda.GetPersonasEdad();
foreach (Persona p in personasFiltro)
{
    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
}
Console.WriteLine("Filtrando por edad Lambda");
List<Persona> personasFiltroLambda = helperLambda.GetPersonasEdadLambda(20, 40);
foreach (Persona p in personasFiltroLambda)
{
    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
}
Console.WriteLine("Filtrando por edad Patrón propiedades");
List<Persona> personasFiltroPatron = helperLambda.GetPersonasPatronPropiedades();
foreach (Persona p in personasFiltroPatron)
{
    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
}
