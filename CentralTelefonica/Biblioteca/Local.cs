using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Local : Llamada
    {
        private float costo;

        public Local(Llamada llamada, float costo)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        { 
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo)
            : this(new Llamada(duracion, destino, origen), costo)
        {
        }

        public float CostoLlamada
        //La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
        {
            get { return CalcularCosto(); }  
        }

        private float CalcularCosto()
        { //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
            return base.Duracion * this.costo;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.CostoLlamada.ToString());

            return sb.ToString();

        }
    }
}
