using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro Unscripted = new Libro();

            Unscripted[0] = "Capitulo 1";
            Unscripted[1] = "Capitulo 2";
            Unscripted[2] = "Capitulo 3";

            MostrarIndices(Unscripted, 4);

            Unscripted[0] = "Capitulo 0";
            Unscripted[1] = "Capitulo 1.1";

            MostrarIndices(Unscripted, 2);

            Console.ReadKey();
            
        }
        private static void MostrarIndices(Libro index, int cantidadIndices)
        {
            for (int i = 0; i < cantidadIndices; i++)
            {
                Console.WriteLine($"{index[i]}");
            }
        }
    }
}
