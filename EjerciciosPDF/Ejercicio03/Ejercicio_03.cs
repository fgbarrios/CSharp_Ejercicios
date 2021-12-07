using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Ejercicio_03
    {
        /*Mostrar por pantalla todos los números primos 
         * que haya hasta el número que ingrese el usuario por consola.
         * Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).
         * */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 03";

            Console.WriteLine("Ingrese numero: ");
            int num = int.Parse(Console.ReadLine());
            
            if (num == 0 || num == 1)
            {
                Console.WriteLine("Los numeros 0 y 1 no tienen numeros primos.");     
            }
            else
            {
                Console.WriteLine("Ingresaste el numero {0}, los numeros primos hasta ese numero son: ", num);
                for (int i = 2; i < num; i++)
                {
                    if (i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

            Console.ReadKey();
        }
    }
}
