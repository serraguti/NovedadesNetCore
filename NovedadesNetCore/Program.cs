using System.Runtime.CompilerServices;

Console.WriteLine("Ejemplo novedades");
Console.WriteLine("Documentos JSON");
Console.WriteLine("-----------------------------------");
HelperJsonClientes helperJson = new HelperJsonClientes();
List<Cliente> clientesMicrosoft = helperJson.GetClientesMicrosoft();
foreach (Cliente cliente in clientesMicrosoft)
{
    Console.WriteLine(cliente.Nombre);
}

Console.WriteLine("-----------------------------------");
List<Cliente> clientesNewton = helperJson.GetClientesNewton();
foreach (Cliente cliente in clientesNewton)
{
    Console.WriteLine(cliente.Nombre);
}
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
