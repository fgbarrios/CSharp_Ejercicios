using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class CompetenciaNoDisponibleException: Exception
    {
        private string nombreClase;
        private string nombreMetodo;
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo, Exception inner)
            :base(mensaje, inner)
        {
            this.nombreClase = nombreClase;
            this.nombreMetodo = nombreMetodo;
        }
        public CompetenciaNoDisponibleException(string mensaje, string nombreClase, string nombreMetodo)
            : this(mensaje, nombreClase, nombreMetodo, null)
        {
        }
        public string NombreClase { get { return this.nombreClase; } }
        public string NombreMetodo { get { return this.nombreMetodo; } }

        //La sobrescritura del método ToString retornará un mensaje con el siguiente formato por líneas:
            //"Excepción en el método {0} de la clase {1}:"
            //Mensaje propio de la excepción.
            //Todos los InnerException con una tabulación(\t).
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("Excepción en el método {0} de la clase {1}: ", this.NombreClase, this.NombreMetodo);
            sb.AppendLine($"Algo malio sal. {this.Message}");
            if (this.InnerException is not null)
            {
                sb.AppendLine($"Mensaje Inner Exception: {this.InnerException.Message} \t");
            }            

            return sb.ToString();
        }
    }
}
