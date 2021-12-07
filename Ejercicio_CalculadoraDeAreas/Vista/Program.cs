using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Area de un cuadrado de lado 8 : " + CalculadoraDeArea.CalcularAreaCuadrado(5));

            Console.WriteLine("Area de un triangulo de altura 6 y base 3: " + CalculadoraDeArea.CalcularAreaTriangulo(3, 6));

            Console.WriteLine("Area de un circulo de radio 3: " + CalculadoraDeArea.CalcularAreaCirculo(3));


        }
    }
}
