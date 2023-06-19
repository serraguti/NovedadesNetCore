using Microsoft.Extensions.DependencyInjection;
using NovedadesNetCore;
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;

Console.WriteLine("Ejemplo DI/IoC");
//ME GUSTARIA PODER DECIRLE AL CONTROLADOR QUE OBJETO DEBE UTILIZAR
//NO TENEMOS CONTENEDOR Y TAMPOCO LO VAMOS A CREAR
//REALIZAMOS AQUI LA INYECCION
//CREAMOS UN PROVEEDOR/CONTAINER
var provider = new ServiceCollection()
    .AddTransient<ICoche, Deportivo>()
    .AddTransient<CocheController>()
    .BuildServiceProvider();
//NECESITAMOS PODER RECUPERAR UN CONTROLLER PARA TRABAJAR CON EL

CocheController controller = provider.GetService<CocheController>();
string respuesta = "";
while (respuesta != "0")
{
    Console.WriteLine(controller.DescripcionCoche());
    string datos = "";
    Console.WriteLine("0.- Salir");
    Console.WriteLine("1.- Acelerar");
    Console.WriteLine("2.- Frenar");
    respuesta = Console.ReadLine();
    int seleccion = int.Parse(respuesta);
    if (seleccion == 1)
    {
        datos = controller.AcelerarCoche();
    }
    else if (seleccion == 2)
    {
        datos = controller.FrenarCoche();
    }
    else{
        Console.WriteLine("Hasta luego");
    }
    Console.WriteLine(datos);
}
Console.WriteLine("Fin de program");


//Console.WriteLine("Documentos JSON");
//Console.WriteLine("-----------------------------------");
//HelperJsonClientes helperJson = new HelperJsonClientes();
//List<Cliente> clientesNewton = helperJson.GetClientesNewton();
//Cliente cliente = clientesNewton[0];
//string jsonNewton = helperJson.SerializarClienteNewton(cliente);
//string jsonMicrosoft = helperJson.SerializarClienteMicrosoft(cliente);
//Console.WriteLine("NEWTON");
//Console.WriteLine(jsonNewton);
//Console.WriteLine("-----------------------------------");
//Console.WriteLine("MICROSOFT");
//Console.WriteLine(jsonMicrosoft);

//foreach (Cliente cliente in clientesMicrosoft)
//{
//    Console.WriteLine(cliente.Nombre + " " + cliente.Imagen);
//}

//Console.WriteLine("-----------------------------------");
//List<Cliente> clientesNewton = helperJson.GetClientesNewton();
//foreach (Cliente cliente in clientesNewton)
//{
//    Console.WriteLine(cliente.Nombre + " " + cliente.Imagen);
//}
//Console.WriteLine("Ejemplo async/await");
//string path = @"C:\Users\Serra\Documents\CEDEX\Contacto Curso Cedex.txt";
//string data = await HelperFiles.ReadFileAsync(path);
//Console.WriteLine(data);

//Console.WriteLine("Lambda");
//HelperLambda helperLambda = new HelperLambda();
//List<int> numeros = helperLambda.GetElementosPaginadosTake(0, 5);
//foreach (int num in numeros)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine("Siguientes...");
//List<int> numeros1 = helperLambda.GetElementosPaginadosTake(5, 10);
//foreach (int num in numeros1)
//{
//    Console.WriteLine(num);
//}
//List<int> numeros = helperLambda.GetElementosPaginados(0,5);
//foreach (int num in numeros)
//{
//    Console.WriteLine(num);
//}
//Console.WriteLine("Siguientes 5");
//List<int> numeros2 = helperLambda.GetElementosPaginados(5, 5);
//foreach (int num in numeros2)
//{
//    Console.WriteLine(num);
//}




//List<Persona> personas = helperLambda.GetPersonas();
//foreach (Persona p in personas)
//{
//    Console.WriteLine(p.IdPersona + " - " + p.Nombre);
//}
//Console.WriteLine("Max y MaxBy Lambda");
//var valor = personas.Max(x => x.Edad);
//Console.WriteLine("Valor Max: " + valor);
////NOVEDAD ES UTILIZAR MAXBY, QUE DEVUELVE EL OBJETO
//var dato = personas.MaxBy(x => x.Edad);
//Console.WriteLine("Dato MaxBy: " + dato.Nombre);


//Console.WriteLine("Filtrando por edad");
//List<Persona> personasFiltro = helperLambda.GetPersonasEdad();
//foreach (Persona p in personasFiltro)
//{
//    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
//}
//Console.WriteLine("Filtrando por edad Lambda");
//List<Persona> personasFiltroLambda = helperLambda.GetPersonasEdadLambda(20, 40);
//foreach (Persona p in personasFiltroLambda)
//{
//    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
//}
//Console.WriteLine("Filtrando por edad Patrón propiedades");
//List<Persona> personasFiltroPatron = helperLambda.GetPersonasPatronPropiedades();
//foreach (Persona p in personasFiltroPatron)
//{
//    Console.WriteLine(p.IdPersona + " - " + p.Nombre + ", Edad: " + p.Edad);
//}
