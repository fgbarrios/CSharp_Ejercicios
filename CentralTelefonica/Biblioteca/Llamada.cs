using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Llamada
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
        // FIN DE PROPIEDADES

        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nro Origen: {this.NroOrigen}");
            sb.AppendLine($"Nro Destino: {this.NroDestino}");
            sb.AppendLine($"Duracion: {this.Duracion.ToString()}");

            return sb.ToString();            

        }

        public static int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            // ordenar de forma ascendente
            return llamada1.Duracion.CompareTo(llamada2.Duracion);

        }

    }
}
