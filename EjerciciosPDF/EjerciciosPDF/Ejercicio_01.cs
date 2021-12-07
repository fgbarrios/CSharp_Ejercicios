using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPDF
{
    class Ejercicio_01
    {
        //Para visualizar los valores decimales de los ejercicios, Ud. deberá dar el siguiente formato de salida al
        //método Write/WriteLine: “#,###.00”.
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 01";

            Console.WriteLine("Ejercicio 01");

            int numMayor = 0;
            int numMenor = 0;
            int acumulador = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese numero {0}: ", i + 1);
                string num_cadena = Console.ReadLine();

                int num = int.Parse(num_cadena);

                //guardar valor maximo
                if(i == 0 || num > numMayor)
                {
                    numMayor = num;
                }

                // guardar valor minimo
                if(i == 0 || num < numMenor)
                {
                    numMenor = num;
                }

                // guardar promedio
                acumulador += num;
            }

            //mostrar maximo
            Console.WriteLine("El numero ingresado mayor es: " + numMayor);

            // mostrar minimo
            Console.WriteLine("El numero ingresado menor es: " + numMenor);

            // mostrar promedio
            Console.WriteLine("El promedio de los numeros ingresados es: " + acumulador / 5);
            Console.ReadKey();

        }

    }
}
