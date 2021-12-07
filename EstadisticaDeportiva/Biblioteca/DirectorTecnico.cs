using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class DirectorTecnico : Persona
    {

        private DateTime fechaNacimiento;

        private DirectorTecnico(string nombre)
            :base(nombre)
        { 
            
        }
        public DirectorTecnico(string nombre, DateTime fechaNacimiento)
            : base(nombre)
        {
            this.fechaNacimiento = fechaNacimiento;
        }

        public override string MostrarDatos() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.Nombre}");
            sb.AppendLine($"Fecha de nacimiento: {fechaNacimiento.ToLongDateString()}");

            return sb.ToString();
        }

        //Dos directores técnicos serán iguales si tienen el mismo nombre y fecha de nacimiento.
        public static bool operator ==(DirectorTecnico d1, DirectorTecnico d2)
        {
            if (d1.Nombre is not null && d2.Nombre is not null) 
            {
                if ((DateTime.Compare(d1.fechaNacimiento, d2.fechaNacimiento) == 0) && (d1.Nombre == d2.Nombre))
                {
                    return true;
                }
            }            
            return false;    

        }

        public static bool operator !=(DirectorTecnico d1, DirectorTecnico d2)
        {
            return !(d1 == d2);
        }

    }
}
