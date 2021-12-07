using System;

namespace Biblioteca
{
    public static class CalculadoraDeArea
    {        
        private const double PI = 3.1415926535897931;

        public static double CalcularAreaCuadrado(double longitudLado) 
        {
            return Math.Pow(longitudLado,2);
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura) 
        {
            return (baseTriangulo * altura) / 2;
        }

        public static double CalcularAreaCirculo(double radio) 
        {
            return PI * Math.Pow(radio, 2);
        }

    }
}
