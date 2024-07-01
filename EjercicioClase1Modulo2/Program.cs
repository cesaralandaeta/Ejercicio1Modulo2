
using System.Text.Json;

namespace EjercicioClase1Modulo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio clase 1 modulo 2");
            // Consigna:
            // En la ruta principal del proyecto hay 3 archivos json, para cada uno de ellos crear las clases que consideren necesarias para poder deserializar correctamente
            // Uso: JsonSerializer.Deserialize<ClaseCreada>(data);

            var pathEjercicio1 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio1.json";
            var pathEjercicio2 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio2.json";
            var pathEjercicio3 = $"{AppDomain.CurrentDomain.BaseDirectory}/Ejercicio3.json";

            var dataEjercicio1 = File.ReadAllText(pathEjercicio1);
            var dataEjercicio2 = File.ReadAllText(pathEjercicio2);
            var dataEjercicio3 = File.ReadAllText(pathEjercicio3);

            var resultado_ejecicio1 = JsonSerializer.Deserialize<RedSocialEjer1>(dataEjercicio1);
            var sedultado_ejercicio2 = JsonSerializer.Deserialize<Torneo>(dataEjercicio2);
            var resultado_ejercicio3 = JsonSerializer.Deserialize<Market>(dataEjercicio3);
            Console.WriteLine("ejercicio1"); 
        }
    }
}