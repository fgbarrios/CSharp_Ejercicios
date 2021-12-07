using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        /*
         * Realizar un programa que sume números enteros hasta que el usuario lo determine por medio de un mensaje 
         * "¿Desea continuar? (S/N)".
        Crear la clase Validador y el método estático ValidarRespuesta, que validará el ingreso de respuestas.
        El método devolverá un valor de tipo booleano, TRUE si se ingresó una 'S' y FALSE si se ingresó cualquier otro valor.
         * */
        static void Main(string[] args)
        {
            char respuesta = 'S';
            int numero;
            int acumulador = 0;

            while (Validador.ValidarRespuesta(respuesta))
            {
                Console.WriteLine("Ingresar numero a sumar:");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;

                Console.WriteLine("Desea continuar ingresando caracteres? S / N");
                respuesta = char.Parse(Console.ReadLine());
            }

            Console.WriteLine($"La suma de las variables ingresadas es: {acumulador}");
        }
    }
}
