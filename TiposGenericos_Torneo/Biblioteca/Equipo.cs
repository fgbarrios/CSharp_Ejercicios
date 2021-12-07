using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Equipo
    {
        //Agregar un atributo nombre de tipo string y otro fechaCreacion de tipo DateTime.
        private string nombre;
        private DateTime fechaCreacion;

        /*private Equipo()
        {
            fechaCreacion = new DateTime();
        }
        */
        public string Nombre { get { return this.nombre; } }

        public Equipo(string nombre, DateTime fechaCreacion)
        {
            this.nombre = nombre;
            this.fechaCreacion = fechaCreacion;
        }

        //Dos equipos serán iguales si comparten el mismo nombre y fecha de creación.
        public static bool operator ==(Equipo equipo1, Equipo equipo2)
        {
            return equipo1.nombre == equipo2.nombre && equipo1.fechaCreacion == equipo2.fechaCreacion;
        }

        public static bool operator !=(Equipo equipo1, Equipo equipo2)
        {
            return !(equipo1 == equipo2);
        }

        //El método Ficha retornará el nombre del equipo y su fecha de creación con el siguiente formato:
        //[EQUIPO] fundado el [FECHA]

        public string Ficha()
        {
            return $"[{this.nombre}] fundado el [{this.fechaCreacion.ToString("dd/MM/yyyy")}]";
        }

    }
}
