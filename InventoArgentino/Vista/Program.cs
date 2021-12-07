using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*En el método Main, crear un bolígrafo de tinta azul (ConsoleColor.Blue)
             * y una cantidad inicial de tinta de 100 y otro de tinta roja (ConsoleColor.Red) y 50 de tinta.
            Utilizar todos los métodos y mostrar los resultados por consola.
            Al utilizar el método Pintar, si corresponde, se deberá dibujar por pantalla con el color de dicho bolígrafo.

             * */
            Boligrafo b1 = new Boligrafo(ConsoleColor.Blue, 100);
            Boligrafo b2 = new Boligrafo(ConsoleColor.Red, 50);

            string dibujo;

            Console.WriteLine($"El nivel de tinta actual de b1 es: {b1.GetTinta()}");
            Console.ForegroundColor = b1.GetColor();
            b1.Pintar(20, out dibujo);
            Console.WriteLine(dibujo);

            Console.WriteLine($"El nivel de tinta actual de b1 es: {b1.GetTinta()}");

            b1.Pintar(30, out dibujo);
            Console.WriteLine(dibujo);

            Console.WriteLine($"El nivel de tinta actual de b1 es: {b1.GetTinta()}");

            b1.Pintar(60, out dibujo);
            Console.WriteLine(dibujo);

            Console.WriteLine($"El nivel de tinta actual de b1 es: {b1.GetTinta()}");

            b1.Pintar(60, out dibujo);
            Console.WriteLine(dibujo);
        }
    }
}
