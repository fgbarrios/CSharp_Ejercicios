using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Biblioteca.Enumerado;

namespace Biblioteca
{
    public class Camion : VehiculoTerrestre
    {
        //Camion tendrá los atributos:
        //cantidadRuedas: short,
        //cantidadPuertas : short,
        //color : Colores,
        //cantidadMarchas : short,
        //pesoCarga : int.

        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private Colores color;
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int pesoCarga)
            :base(cantidadRuedas, cantidadPuertas, color)
        {
            this.cantidadMarchas = cantidadMarchas;
            this.pesoCarga = pesoCarga;
        }
    }
}
