using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class VehiculoDeCarrera
    {
        protected short cantidadCombustible;
        protected bool enCompetencia;
        protected string escuderia;
        protected short numero;
        protected short vueltasRestantes;

        public VehiculoDeCarrera(string escuderia, short numero)
        {
            this.escuderia = escuderia;
            this.numero = numero;
        }

        public short CantidadCombustible
        {
            get { return this.cantidadCombustible; }
            set{ this.cantidadCombustible = value; }
        }

        public bool EnCompetencia
        {
            get{return this.enCompetencia;}
            set {this.enCompetencia = value;}
        }

        public short VueltasRestantes
        {
            get{ return this.vueltasRestantes;}
            set{ this.vueltasRestantes = value;}
        }

        public string Escuderia
        {
            get{return this.escuderia;}
            set{this.escuderia = value;}
        }

        public short Numero
        {
            get{return this.numero; }
            set{ this.numero = value;}
        }

        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Numero: {this.Numero.ToString()}");
            sb.AppendLine($"Escuderia: {this.Escuderia}");
            sb.AppendLine($"Cantidad de combustible: {this.CantidadCombustible.ToString()}");
            sb.AppendLine($"Vueltas Restantes: {this.VueltasRestantes.ToString()}");
            sb.AppendLine($"En Competencia: {this.EnCompetencia.ToString()}");

            return sb.ToString();
        }

        // SOBRECARGAS
        //Dos VehiculoDeCarrera son iguales si coincide su número y escudería.
        public static bool operator ==(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            if (a.numero == b.numero && a.escuderia == b.escuderia)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(VehiculoDeCarrera a, VehiculoDeCarrera b)
        {
            return !(a == b);
        }
    }
}
