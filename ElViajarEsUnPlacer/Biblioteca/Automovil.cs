using System;
using static Biblioteca.Enumerado;

namespace Biblioteca
{
    public class Automovil : VehiculoTerrestre
    {
        //Automovil tendrá los atributos:
        //cantidadRuedas : short,
        //cantidadPuertas : short,
        //color : Colores,
        //cantidadMarchas : short,
        //cantidadPasajeros : int.

        //private short cantidadRuedas;
        //private short cantidadPuertas;
        //private Colores color;
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil(short cantidadRuedas, short cantidadPuertas, Colores color, short cantidadMarchas, int cantidadPasajeros)
            : base(cantidadRuedas, cantidadPuertas, color)
        {

            this.cantidadMarchas = cantidadMarchas;
            this.cantidadPasajeros = cantidadPasajeros;
        }
    }
}
