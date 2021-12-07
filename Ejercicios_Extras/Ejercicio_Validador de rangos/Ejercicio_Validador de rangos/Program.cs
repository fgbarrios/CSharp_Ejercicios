using System;
using System.Text;
using Biblioteca;

namespace Ejercicio_Validador_de_rangos
{
    class Program
    {
        // atributos
        private static int valorMinimo;
        private static int valorMaximo;

        static void Main(string[] args)
        {
            //Pedir al usuario que ingrese 10 números enteros.
            //Validar con el método desarrollado anteriormente que estén dentro del rango -100 y 100.

            int numeroIngresado;
            int valorMayor = 0;
            int valorMenor = 0;
            int acumulador = 0;

            valorMaximo = 100;
            valorMinimo = -100;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingresa numero {i + 1}");
                numeroIngresado = int.Parse(Console.ReadLine());

                if (Validador.Validar(numeroIngresado, valorMinimo, valorMaximo))
                {
                    //Terminado el ingreso mostrar el valor mínimo ingresado, valor máximo ingresado y el promedio.
                    if (i == 0 || numeroIngresado < valorMenor)
                    {
                        valorMenor = numeroIngresado;
                    }
                    else if (i == 0 || numeroIngresado > valorMayor)
                    {
                        valorMayor = numeroIngresado;
                    }
                    // acumulador para calcular el promedio
                    acumulador += numeroIngresado;

                }
                else {
                    Console.WriteLine("El numero ingresado esta fuera del rango (-100 / 100). Reingresar.");
                    i--;
                }

            }// fin del for

            StringBuilder stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"El numero ingresado mas bajo es: {valorMenor}");
            stringBuilder.AppendLine($"El numero ingresado mas alto es: {valorMayor}");
            stringBuilder.AppendLine($"El promedio es: {acumulador / 10}");
            stringBuilder.Append("Fin....");

            // despues de armar el texto, lo muestro
            Console.WriteLine(stringBuilder.ToString());


        }
    }
}
