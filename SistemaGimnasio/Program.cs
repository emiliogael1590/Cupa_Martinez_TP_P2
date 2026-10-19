using SistemaGimnasio.Modelos;
using SistemaGimnasio.Servicios;
using SistemaGimnasio.Gestores;
Console.WriteLine("Sistema de gestion de gimnasio");

//Crear Usuario
Console.WriteLine("Ingrese el nombre del usuario");
var nombreUsuario = Console.ReadLine();

Console.Write("Ingresa la edad del usuario");
int usuarioEdad = int.Parse(Console.ReadLine()??"");
Console.WriteLine("Ingresa el objetivo del usuario");
var objetivoUsuario = Console.ReadLine() ?? "";

var usuario = new Usuario(nombreUsuario, usuarioEdad, objetivoUsuario);

//Crear Entrenador
Console.Write("ingrese el nombre del entrenador");
var nombreEntrenador= Console.ReadLine() ?? "";

Console.Write("ingrese la especialidad del entrenador");
var especialidadEntrenador = Console.ReadLine() ?? "";

var entrenador = new Entrenador(nombreEntrenador, especialidadEntrenador);

//Crear Rutina
Console.Write("ingrese el nombre de la rutina: ");
var nombreRunina = Console.ReadLine() ?? "";

Console.Write("ingrese el nombre de la rutina: ");
int duracionRutina = int.Parse(Console.ReadLine() ?? "");
var rutina = new Rutina(nombreRunina, duracionRutina);

//Agregar ejercicios a la rutina
Console.WriteLine("Cuantos ejercicios va atener la rutina?");
int numEjercicios = int.Parse(Console.ReadLine() ?? "");

for (int i = 1; i <= numEjercicios; i++);
{
    Console.WriteLine($"Ejercicio # {i}");

    Console.WriteLine("Nombre del ejercicio");
    var nombreEjercicio = Console.ReadLine() ?? "";

    Console.WriteLine("Nombre del ejercicio");
    int repeticiones = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Nombre del ejercicio");
   int series = int.Parse(Console.ReadLine() ?? "");

    Console.WriteLine("Nombre del ejercicio");
    int descanso = int.Parse(Console.ReadLine() ?? "");

    var ejercicio = new Ejercicio(nombreEjercicio, repeticiones, series, descanso);
    rutina.AgregarEjercicio(ejercicio);
}

//Asignar rutina al usuario

var asignador = new AsignadorDeRutinas();
asignador.AsignarRutinaAlUsuario(usuario,rutina);
asignador.AsignarUsuarioAEntrenador(usuario, entrenador);

//Muestre Resumen

Console.WriteLine("Resumen de asignasiones: ");
Console.WriteLine($"Usuario {usuario.Nombre}  rutina: {usuario.RutinaAsignada.Nombre}");
Console.WriteLine($"Entrenador Asignado {entrenador.Nombre}");
Console.WriteLine("Ejercicios de la rutina: ");
foreach(var e in usuario.RutinaAsignada.ObtenerEjercicios())
{
    Console.WriteLine($"{e.Nombre} | Series: {e.Series} | {e.Repeteciciones} | Descano{e.Descanso}");
}

