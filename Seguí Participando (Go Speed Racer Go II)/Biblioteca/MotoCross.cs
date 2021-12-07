using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class MotoCross :VehiculoDeCarrera
    {
        private short cilindrada;

        public MotoCross(short numero, string escuderia)
            :base(escuderia, numero)
        {
            base.cantidadCombustible = 0;
            base.vueltasRestantes = 0;
        }
        public MotoCross(short numero, string escuderia, short cilindrada)
            :base(escuderia, numero)
        {
            this.cilindrada = cilindrada;
        }

        // PROPIEDADES
        public short Cilindrada
        { 
            get { return this.cilindrada; }
            set { this.cilindrada = value; } 
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {base.Numero.ToString()}");
            sb.AppendLine($"Escuderia: {base.Escuderia}");
            sb.AppendLine($"Cantidad de combustible: {base.CantidadCombustible.ToString()}");
            sb.AppendLine($"Vueltas Restantes: {base.VueltasRestantes.ToString()}");
            sb.AppendLine($"En Competencia: {base.EnCompetencia.ToString()}");
            sb.AppendLine($"Cilindrada: {this.Cilindrada.ToString()}");

            return sb.ToString();
        }

        // SOBRECARGAS
        //Dos MotoCross son iguales si coincide cuando,
        //además de coincidir los datos contenidos en VehiculoDeCarrera,
        //coincida el atributo cilindrada.
        public static bool operator ==(MotoCross a, MotoCross b)
        {
            if (a.numero == b.numero && a.escuderia == b.escuderia && a.Cilindrada == b.Cilindrada)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(MotoCross a, MotoCross b)
        {
            return !(a == b);
        }


    }
}
