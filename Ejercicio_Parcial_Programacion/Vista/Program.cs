using System;
using System.Collections.Generic;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>();
            lista.Add(new Persona("Tito"));
            lista.Add(new Persona("Pepe"));
            lista.Add(new Persona("Roberto"));
            lista.Add(new Persona("Julia"));
            lista.Add(new Persona("Susana"));

            foreach (Persona item in lista)
            {
                if (item.nombre == "Tito")
                {
                    lista.Remove(item);
                }
            }

        }
    }
}
