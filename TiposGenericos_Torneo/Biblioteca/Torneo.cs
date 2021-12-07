using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Torneo<T> where T: Equipo //Restringir el tipo genérico para que deba ser del tipo Equipo o sus derivados.
    {
        // para obtener el valor por defecto de T, se pude declarar
        //private T atributo = default(T);
        // En caso de que tipo T sea una clase, va a buscar su constructor por defecto.

        private List<T> equipos;
        private string nombre;

        public Torneo()
        {
            this.equipos = new List<T>();
        }
        public Torneo(List<T> equipos, string nombre)
            :this()
        {
            this.equipos = equipos;
            this.nombre = nombre;
        }
        public Torneo(string nombre)
            : this()
        {
            this.nombre = nombre;
        }

        //Sobrecargar el operador == para que controle si un equipo ya está inscripto al torneo.

        public static bool operator ==(Torneo<T> torneo, T equipo)
        {
            foreach (T equiposEnTorneo in torneo.equipos)
            {
                if (equiposEnTorneo == equipo)
                {
                    return true;
                }                
            }
            return false;
        }

        public static bool operator !=(Torneo<T> torneo, T equipo)
        {            
             return !(torneo == equipo);            
        }

        //Sobrecargar el operador + para agregar un equipo a la lista, siempre y cuando este no se encuentre ya en el torneo.
        public static bool operator +(Torneo<T> torneo, T equipo)
        {
            if ((torneo is not null && equipo is not null) && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
                return true;

            }
            return false;
        }

        //El método Mostrar retornará los datos del torneo y de los equipos participantes.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del Torneo: {this.nombre}");
            foreach (T item in this.equipos)
            {
                sb.AppendLine($"Equipo: {item.Ficha()}");
            }
            return sb.ToString();

        }

        //El método privado CalcularPartido recibirá dos elementos del tipo T,
        //que deberán ser del tipo Equipo o sus herencias, y calculará utilizando la clase Random
        //un resultado del partido.
        //Retornará el resultado como un string con el siguiente formato donde EQUIPOX
        //es el nombre del equipo y RESULTADOX la cantidad de goles/puntos:
        //[EQUIPO1][RESULTADO1] – [RESULTADO2][EQUIPO2]
        private string CalcularPartido(T equipo1, T equipo2)
        {
            Random numeroRandom = new Random();
            int random = numeroRandom.Next(0, 5);
            int random2 = numeroRandom.Next(0, 5);

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"[{equipo1.Nombre}][{random}] - [{equipo2.Nombre}][{random2}]");

            return sb.ToString();
        }

        //La propiedad pública JugarPartido tomará dos equipos de la lista al azar
        //y calculará el resultado del partido a través del método CalcularPartido.

        public string JugarPartido 
        { 
            get 
            {
                int cantidadEquipos = this.equipos.Count;
                Random random = new Random();
                T equipo1;
                T equipo2;

                do {
                    
                    int random1 = random.Next(0, cantidadEquipos);
                    int random2 = random.Next(0, cantidadEquipos);

                    equipo1 = this.equipos[random1];
                    equipo2 = this.equipos[random2];


                } while (equipo1 == equipo2);                

                return this.CalcularPartido(equipo1, equipo2);
            } 
        }







    }
}
