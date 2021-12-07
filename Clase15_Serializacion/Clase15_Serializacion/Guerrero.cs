using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase15_Serializacion
{
    public class Guerrero : Personaje
    {
        private int puntosDeFuerza;

        public Guerrero()
        {

        }

        public Guerrero(int puntosDeVida, string nombre, int puntosDeFuerza)
            :base(puntosDeVida, nombre)
        {
            this.puntosDeFuerza = puntosDeFuerza;       
        }

        public int PuntoDeFuerza { get { return this.puntosDeFuerza; } set { this.puntosDeFuerza = value; } }

        public override string ToString()
        {
            return $"{base.ToString()} - Puntos de fuerza: {this.PuntoDeFuerza}";
        }

    }
}
