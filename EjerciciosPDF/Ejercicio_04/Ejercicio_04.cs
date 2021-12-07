using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class Ejercicio_04
    {
        /*Un número perfecto es un entero positivo, 
         * que es igual a la suma de todos los enteros positivos 
         * (excluido el mismo) que son divisores del número. 
         * El primer número perfecto es 6, 
         * ya que los divisores de 6 son 1, 2 y 3; y 1 + 2 + 3 = 6. 
         * Escribir una aplicación que encuentre los 4 primeros números perfectos. 
         * Nota: Utilizar estructuras repetitivas y selectivas.
         * 
         * */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 04";
            
            int iterar = 0;
            int num = 1;
            int acumulador;

            do
            {
                acumulador = 0;
                for (int divisor = 1; divisor < num ; divisor++)
                {
                    if (num % divisor == 0)
                    {
                        acumulador += divisor;
                    }
                }

                if (acumulador == num)
                {
                    Console.WriteLine("El numero {0} es perfecto", num);
                    iterar++;
                }

                num++;

            } while (iterar < 4);

            Console.ReadKey();

        }
            
     
    }
}
