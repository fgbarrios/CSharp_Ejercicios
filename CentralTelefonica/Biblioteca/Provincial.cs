using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    
    public class Provincial: Llamada
    {
        private Franja franja;
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }

        public Provincial(Franja franja, Llamada llamada)
            :base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen)
        {
            this.franja = franja;
        }
        public Provincial(string origen, Franja franja, float duracion, string destino)
            : this(franja, new Llamada(duracion, destino, origen))
        {
        }

        public float CostoLlamada
        {
            get { return CalcularCosto(); }
        }

        private float CalcularCosto()
        {
            float resultado = 0;
            switch (this.franja)
            {
                case Franja.Franja_1:
                    resultado =  (float)base.Duracion * 0.99f;
                    break;
                case Franja.Franja_2:
                    resultado = (float)base.Duracion * 1.25f;
                    break;
                case Franja.Franja_3:
                    resultado = (float)base.Duracion * 0.66f;
                    break;
            }
            return resultado;
            
        }

        //Método Mostrar retornará como texto todos los datos de la clase base
        //y agregará el costo de la llamada y la franja horaria. Utilizar StringBuilder.
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine(this.CostoLlamada.ToString());
            sb.AppendLine(this.franja.ToString());

            return sb.ToString();
        }

    }
}
