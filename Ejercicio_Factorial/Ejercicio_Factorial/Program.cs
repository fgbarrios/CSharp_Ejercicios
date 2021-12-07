using System;

namespace Ejercicio_Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //El factorial de un número es una operación que consiste en multiplicar
            //un numero “n” por todos los números enteros positivos que estén debajo de él,
            //por ejemplo el factorial de 3 es el resultado de multiplicar 3 por 2 por 1.
            //En una aplicación de consola, desarrollar un método estático que calcule el factorial de un número dado.

            int numeroIngresado;

            Console.WriteLine("Ingresar numero a factorizar:");
            numeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine($"El factorial del numero ingresado es: {Factorizar(numeroIngresado)}");
        }

        private static int Factorizar(int num)
        {
            int resultado = num;

            if (num == 0 || num == 1)
            {
                resultado = 1;
            }
            else
            {
                for (int i = num-1; i >= 1; i--)
                {
                    resultado *= i;

                }
            }
            return resultado;
        
        }
    }
}
