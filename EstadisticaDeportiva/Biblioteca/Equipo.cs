using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Equipo
    {
        private short cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        // agregado
        private DirectorTecnico dt;

        //La lista de jugadores se inicializará sólo en el constructor privado de Equipo.
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
            this.dt = new DirectorTecnico(" ", new DateTime());
        }

        public Equipo(short cantidadDeJugadores, string nombre)
            :this()
        {
            this.nombre = nombre;
            this.cantidadDeJugadores = cantidadDeJugadores;
        }        

        //La sobrecarga del operador + agregará jugadores a la lista siempre
        //y cuando no exista aún en el equipo y la cantidad de jugadores no supere el límite establecido
        //por el atributo cantidadDeJugadores.
        public static bool operator +(Equipo e, Jugador j)
        {
            if (e.jugadores.Count < e.cantidadDeJugadores)
            {
                foreach (Jugador item in e.jugadores)
                {
                    if (j == item)
                    {
                        return false;
                    }
                }
                e.jugadores.Add(j);
                return true;
            }
            return false;
        }

        public static bool operator +(Equipo e, DirectorTecnico j)
        {
            if (e.dt.Nombre == " ")
            {
                e.dt = j;
                return true;
            }
            return false;
        }

    }
}
