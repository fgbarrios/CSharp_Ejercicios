using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Ejercicio_02
    {

        /*Ingresar un número y mostrar: el cuadrado y el cubo del mismo. 
         * Se debe validar que el número sea mayor que cero, caso contrario, 
         * mostrar el mensaje: "ERROR. ¡Reingresar número!". 
         * Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.
         */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 02";

            Console.WriteLine("Ingrese un numero:");
            string num_cadena = Console.ReadLine();

            int num = int.Parse(num_cadena);

            if (num == 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
            }
            else {
                // cuadrado del numero ingresado
                Console.WriteLine("El cuadrado del numero ingresado es: " + Math.Pow(num,2));

                // cubo del numero ingresado
                Console.WriteLine("El cubo del numero ingresado es: " + Math.Pow(num, 3));

            }

            Console.ReadKey();
        }
    }
}
