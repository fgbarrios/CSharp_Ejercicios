using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public abstract class Llamada
    {
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        public enum ETipoLlamada
        {
            Local, Provincial, Todas
        }

        public Llamada(float duracion, string nroDestino, string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }

        // PROPIEDADES
        public float Duracion
        { 
            get { return this.duracion; } 
        }
        public string NroDestino
        {
            get { return this.nroDestino; }
        }
        public string NroOrigen
        {
            get { return this.nroOrigen; }
        }

        public abstract float CostoLlamada { get ;}

        // FIN DE PROPIEDADES

        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nro Origen: {this.NroOrigen}");
            sb.AppendLine($"Nro Destino: {this.NroDestino}");
            sb.AppendLine($"Duracion: {this.Duracion.ToString()} minutos");

            return sb.ToString();          
        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            // ordenar de forma ascendente
            return llamada1.Duracion.CompareTo(llamada2.Duracion);

        }

        public static bool operator ==(Llamada llamada1, Llamada llamada2)
        {
            //El operador == comparará dos llamadas y retornará true si las llamadas
            //son del mismo tipo (utilizar el método Equals, sobrescrito en las clases derivadas)
            //y los números de destino y origen son iguales en ambas llamadas.
            if (llamada1.Equals(llamada2) && llamada1.NroOrigen == llamada2.NroOrigen)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Llamada llamada1, Llamada llamada2)
        {
            return !(llamada1 == llamada2);
        }

    }
}
