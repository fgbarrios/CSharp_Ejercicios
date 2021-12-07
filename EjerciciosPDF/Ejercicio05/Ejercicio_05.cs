using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class Ejercicio_05
    {
        /*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1)
         * en dos grupos de números, cuyas sumas son iguales.
         * El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: 
         * (1; 2; 3; 4; 5) y (7; 8) cuyas sumas son ambas iguales a 15. 
         * El segundo centro numérico es el 35, 
         * el cual separa la lista (1 a 49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595. 
         * Se pide elaborar una aplicación que calcule los centros numéricos entre 1 
         * y el número que el usuario ingrese por consola. 
         * Nota: Utilizar estructuras repetitivas y selectivas.
         * 
         * */
        static void Main(string[] args)
        {
            int num;
            int flag = 0;
            int numAtras = 0;
            int numAdelante = 0;

            Console.Title = "Ejercicio Nro. 05";

            Console.WriteLine("Ejercicio 05");

            Console.WriteLine("Ingrese numero (mayor a 1): ");
            num = int.Parse(Console.ReadLine());

            if (num < 2)
            {
                Console.WriteLine("El numero debe ser superior a 1");
                flag = 1;
            }
            else
            {
                // for para pasar por todos los numeros, desde 1 a uno antes del ingresado
                for (int i = 2; i < num; i++)
                {
                    for (int j = 1; j < i; j++)
                    {
                        numAtras += j;
                        
                    }

                    for (int j = i + 1; j <= num; j++)
                    {
                        numAdelante += j;

                    }

                    if (numAtras == numAdelante)
                    {
                        Console.WriteLine("El centro numerico es el numero {0}", i);
                        flag = 1;
                    }

                    numAtras = 0;
                    numAdelante = 0;
                    
                }

            }

            if (flag == 0)
            {
                Console.WriteLine("No hay centro numerico entre 1 y {0}", num);
            }

            Console.ReadKey();
        }
    }
}
