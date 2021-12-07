using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Jugador : Persona
    {
        //private int dni;
        //private string nombre;

        private int partidosJugados;
        //private float promedioGoles;
        private int totalGoles;

        // PROPIEDADES
        /* SE COMENTA PORQUE EN EL EJERCICIO DE HERENCIA (HERENCIA DEPORTIVA) SE UTILIZAN LOS ATRIBUTOS DEFINIDOS EN PERSONA.CS
         * public int Dni
        {
            get
            {
                return this.dni;
            }
            set
            {
                this.dni = value;
            }
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        */
        public int PartidosJugados 
        {
            get 
            {
                return this.partidosJugados;
            }
            set
            {
                this.partidosJugados = value;
            }
        }

        public int TotalGoles
        {
            get
            {
                return this.totalGoles;
            }
            set 
            {
                this.totalGoles = value;
            }
        }

        //Quitar el atributo promedioGoles de jugador. Calcular dicho promedio dentro de la propiedad de sólo lectura PromedioDeGoles.
        public float PromedioDeGoles
        {
            get
            {
                return (float)this.TotalGoles / this.PartidosJugados;
            }
        }

        //Todos los datos estadísticos del jugador se inicializarán en 0 dentro del constructor privado.
        /* SE COMENTA POR EL EJERCICIO DE HERENCIA
         * private Jugador()
        {
            this.partidosJugados = 0;
            //this.promedioGoles = 0;
            this.totalGoles = 0;
        }
        */
        public Jugador(int dni, string nombre)
            : base(dni, nombre)
        {
        }
        public Jugador(int dni, string nombre, int totalGoles, int totalPartidos)
            : base(dni, nombre)
        {
            this.totalGoles = totalGoles;
            this.partidosJugados = totalPartidos;
        }

        //El promedio de gol sólo se calculará cuando invoquen al método GetPromedioGoles. COMENTADO, AHORA SE CALCULA EN LA PROPIEDAD!!
        /*
         public float GetPromedioGoles()
        {
            return (float)this.totalGoles / this.partidosJugados;
        }
        */
        //MostrarDatos retornará una cadena de string con todos los datos y estadísticas del jugador.
        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"DNI: {this.Dni.ToString()}");
            sb.AppendLine($"Partido Jugados: {this.PartidosJugados.ToString()}");
            sb.AppendLine($"Total Goles: {this.TotalGoles.ToString()}");
            sb.AppendLine($"Promedio Goles: {this.PromedioDeGoles.ToString()}");

            return sb.ToString();

        }

        //Dos jugadores serán iguales si tienen el mismo DNI.
        public static bool operator ==(Jugador j1, Jugador j2)
        {
               return j1.dni == j2.dni;

        }

        public static bool operator !=(Jugador j1, Jugador j2)
        {
            return !(j1 == j2);
        }

    }
}
