using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06
{
    class Ejercicio_06
    {
        /*Escribir un programa que determine si un año es bisiesto. 
         * Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, 
         * salvo si ellos también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
         * Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango. 
         * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
         * 
         * */
        static void Main(string[] args)
        {
            int anioInicial;
            int anioFinal;

            Console.Title = "Ejercicio Nro. 06";
            Console.WriteLine("Ejercicio 06");

            Console.WriteLine("Ingrese año inicial: ");
            anioInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese año final: ");
            anioFinal = int.Parse(Console.ReadLine());

            for (int i = anioInicial; i <= anioFinal; i++)
            {
                if (i % 4 == 0 && (i % 100 != 0 || i % 400 == 0))
                {                       
                    Console.WriteLine("El año {0} es bisiesto.", i);
                }
                
            }

            Console.ReadKey();

        }
    }
}
