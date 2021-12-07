using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            string numeros = "1 \n2,3";
            int expected = 6;

            //Act
            int resultado = numeros.Add();

            //Assert
            if (expected == resultado)
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine($"Valor de Resultado: {resultado}");
            }
        }
    }
}
