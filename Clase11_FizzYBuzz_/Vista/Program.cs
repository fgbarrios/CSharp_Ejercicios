using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayNumeros = new int[21];

            int acumulador = 1;

            for (int i = 0; i < arrayNumeros.Length; i++)
            {
                arrayNumeros[i] = acumulador;
                acumulador++;
            }

            Console.WriteLine($"{arrayNumeros.FizzBuzz()}");
            

        }
    }
}
