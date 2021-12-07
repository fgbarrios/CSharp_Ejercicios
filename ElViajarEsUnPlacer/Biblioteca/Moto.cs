using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Enumerado;

namespace Biblioteca
{
    public class Moto : VehiculoTerrestre
    {
        //Moto tendrá los atributos:
        //cantidadRuedas : short,
        //cantidadPuertas : short,
        //color : Colores,
        //cilindrada : short.

        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private Colores color;
        public short cilindrada;

        public Moto(short cantidadRuedas, short cantidadPuertas, Colores color, short cilindrada)
            : base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cilindrada = cilindrada;
        }
    }
}
