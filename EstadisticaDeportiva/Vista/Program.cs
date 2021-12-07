using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            Equipo equipo = new Equipo(2, "utn");
            DirectorTecnico dt1 = new DirectorTecnico("Bielsa", new DateTime(1987,12,02));

            Jugador j1 = new Jugador(123, "nom1", 5, 20);
            Jugador j2 = new Jugador(485, "nom2", 3, 5);
            Jugador j3 = new Jugador(123, "nom3", 7, 3);
            Jugador j4 = new Jugador(789, "nom4", 3, 5);
            //jugador con el mismo DNI
            Jugador j5 = new Jugador(789, "nom8", 8, 6);

            // sumo el dt al equipo
            if (equipo + dt1)
            {
                Console.WriteLine("Entrenador agregado al equipo:");
                Console.WriteLine(dt1.MostrarDatos());
            }

            Console.WriteLine("Jugadores en el equipo:");

            if (equipo + j1)
                Console.WriteLine(j1.MostrarDatos());

            if (equipo + j2)
                Console.WriteLine(j2.MostrarDatos());

            if (equipo + j3)
                Console.WriteLine(j3.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j3.MostrarDatos());

            if (equipo + j4)
                Console.WriteLine(j4.MostrarDatos());
            else
                Console.WriteLine("NO SE AGREGO " + j4.MostrarDatos());

            if (j4 == j5)
                Console.WriteLine("Es el mismo jugador!");
            else
                Console.WriteLine("No funciona el ==");
        }
    }
}
