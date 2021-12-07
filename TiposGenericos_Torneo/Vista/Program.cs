using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Generar dos torneos, uno de Futbol y otro de Basquet.
            Torneo<EquipoFutbol> libertadores = new Torneo<EquipoFutbol>("Libertadores");
            Torneo<EquipoBasquet> nba = new Torneo<EquipoBasquet>("NBA");

            //Crear 3 equipos de cada tipo.
            EquipoFutbol boca = new EquipoFutbol("Boca", DateTime.Now);
            EquipoFutbol river = new EquipoFutbol("River", DateTime.Now);
            EquipoFutbol lanus = new EquipoFutbol("Lanus", DateTime.Now);

            EquipoBasquet argentina = new EquipoBasquet("Arg", DateTime.Now);
            EquipoBasquet chile = new EquipoBasquet("Chile", DateTime.Now);
            EquipoBasquet brasil = new EquipoBasquet("Brasil", DateTime.Now);

            //Agrego los equipos al torneo
            _ = libertadores + boca;
            _ = libertadores + river;
            _ = libertadores + lanus;

            _ = nba + argentina;
            _ = nba + chile;
            _ = nba + brasil;

            // Muestro los equipos
            Console.WriteLine(libertadores.Mostrar());
            Console.WriteLine(nba.Mostrar());

            //Llamar al menos 3 veces a la propiedad JugarPartido de cada torneo
            //e imprimir su respuesta por pantalla.
            Console.WriteLine($"{libertadores.JugarPartido}"); 
            Console.WriteLine($"{libertadores.JugarPartido}"); 
            Console.WriteLine($"{libertadores.JugarPartido}"); 

            Console.WriteLine($"{nba.JugarPartido}"); 
            Console.WriteLine($"{nba.JugarPartido}"); 
            Console.WriteLine($"{nba.JugarPartido}"); 

        }
    }
}
