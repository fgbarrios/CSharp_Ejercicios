using System;
using System.Text;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;

            Console.WriteLine("Ingrese numero entero:");
            numeroIngresado = int.Parse(Console.ReadLine());

            Console.WriteLine(TablaMultiplicacion(numeroIngresado));
        }

        private static string TablaMultiplicacion(int numero)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Tabla de multiplicar del numero: {numero}");

            int resultado;

            for (int i = 1; i < 10; i++)
            {
                resultado = numero * i;
                sb.AppendLine($"{numero} x {i} = {resultado}");
            }

            return sb.ToString();

        }
    }

    
}
