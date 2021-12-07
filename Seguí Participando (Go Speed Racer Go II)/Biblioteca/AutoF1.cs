using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class AutoF1: VehiculoDeCarrera
    {
        private short caballosDeFuerza;

        //Al generar un auto se cargará el atributo enCompetencia como falso.Inicializar cantidadCombustible y vueltasRestantes en 0.
        public AutoF1(short numero, string escuderia)
                :base(escuderia, numero)
        {
            base.cantidadCombustible = 0;
            base.vueltasRestantes = 0;
        }

        public AutoF1(short numero, string escuderia, short caballosDeFuerza)
            :base(escuderia, numero)
        {
            this.caballosDeFuerza = caballosDeFuerza;
        }

        public short CaballosDeFuerza
        {
            get { return this.caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        // SOBRECARGAS
        //Dos AutoF1 serán iguales cuando,
        //además de coincidir los datos contenidos en VehiculoDeCarrera,
        //coincida el atributo caballosDeFuerza.
        public static bool operator ==(AutoF1 a, AutoF1 b)
        {
            if (a.numero == b.numero && a.escuderia == b.escuderia && a.CaballosDeFuerza == b.CaballosDeFuerza)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(AutoF1 a, AutoF1 b)
        {
            return !(a == b);
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {base.Numero.ToString()}");
            sb.AppendLine($"Escuderia: {base.Escuderia}");
            sb.AppendLine($"Cantidad de combustible: {base.CantidadCombustible.ToString()}");
            sb.AppendLine($"Vueltas Restantes: {base.VueltasRestantes.ToString()}");
            sb.AppendLine($"En Competencia: {base.EnCompetencia.ToString()}");
            sb.AppendLine($"Caballos de Fuerza: {this.CaballosDeFuerza.ToString()}");

            return sb.ToString();
        }

    }
}
