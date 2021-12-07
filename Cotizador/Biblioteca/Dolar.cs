using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Dolar
    {
        //1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.

        private double cantidad;
        private static double cotzRespectoDolar;

        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }

        public Dolar(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Dolar(double cantidad, double cotizacion)
            :this(cantidad)
        {
            Dolar.cotzRespectoDolar = cotizacion;
        }
        // PROPIEDADES
        public double GetCantidad
        {
            get { return this.cantidad; }
        }
        public static double GetCotizacion
        {
            get { return Dolar.cotzRespectoDolar; }
        }

        // SOBRECARGA DE OPERADORES

        // OPERADORES EXPLICITOS E IMPLICITOS
        public static explicit operator Euro(Dolar d)
        {
            return new Euro(Euro.GetCotizacion * d.cantidad);
        }
        public static explicit operator Peso(Dolar d)
        {
            return new Peso(Peso.GetCotizacion * d.cantidad);
        }
        public static implicit operator Dolar(double d)
        {
            return new Dolar(d);
        }

        // FIN OPERADORES EXPLICITOS E IMPLICITOS

        // OPERADORES ==  !=
        public static bool operator ==(Dolar d, Euro e)
        {
            return d.cantidad == e.GetCantidad;
        }
        public static bool operator !=(Dolar d, Euro e)
        {
            return !(d == e);
        }

        public static bool operator ==(Dolar d, Peso p)
        {
            return d.cantidad == p.GetCantidad;
        }
        public static bool operator !=(Dolar d, Peso p)
        {
            return !(d == p);
        }
        public static bool operator ==(Dolar d1, Dolar d2)
        {
            return d1.cantidad == d2.cantidad;
        }
        public static bool operator !=(Dolar d1, Dolar d2)
        {
            return !(d1 == d2);
        }

        // FIN OPERADORES ==  !=

        // OPERADORES + - 
        public static Dolar operator +(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator +(Dolar d, Peso e)
        {
            return new Dolar(d.cantidad + ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Euro e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        public static Dolar operator -(Dolar d, Peso e)
        {
            return new Dolar(d.cantidad - ((Dolar)e).cantidad);
        }

        // FIN OPERADORES + - 

    }
}
