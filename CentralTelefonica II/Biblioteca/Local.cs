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
            :this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo)
        { 
        }
        public Local(string origen, float duracion, string destino, float costo)
            :base(duracion, destino, origen)
        {
            this.costo = costo;
        }

        public override float CostoLlamada
        //La propiedad CostoLlamada retornará el precio, que se calculará en el método CalcularCosto.
        {
            get { return CalcularCosto(); }  
        }

        private float CalcularCosto()
        { //CalcularCosto será privado. Retornará el valor de la llamada a partir de la duración y el costo de la misma.
            return base.Duracion * this.costo;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine($"Costo de llamada: ${this.CostoLlamada.ToString()}");

            return sb.ToString();
        }
        //El método Equals retornará true sólo si el objeto que recibe es de tipo Local.
        public override bool Equals(object obj)
        {
            if (obj.GetType() == typeof(Local))
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return this.Mostrar();
        }
    }
}
