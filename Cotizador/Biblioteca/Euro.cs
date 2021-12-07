using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Billetes
{
    public class Euro
    {
        //1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.
        private double cantidad;
        private static double cotzRespectoDolar;

        static Euro()
        {
            Euro.cotzRespectoDolar = 1 / 1.17;
        }

        public Euro(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Euro(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Euro.cotzRespectoDolar = cotizacion;
        }

        // PROPIEDADES
        public double GetCantidad
        {
            get { return this.cantidad; }
        }
        public static double GetCotizacion
        {
            get { return Euro.cotzRespectoDolar; }
        }

        // OPERADORES EXPLICITOS E IMPLICITOS
        public static explicit operator Dolar(Euro e)
        {
            return new Dolar(e.cantidad / cotzRespectoDolar);
        }
        public static explicit operator Peso(Euro e)
        {
            return (Peso) ((Dolar)e);
        }
        public static implicit operator Euro(double d)
        {
            return new Euro(d);
        }

        // FIN OPERADORES EXPLICITOS E IMPLICITOS

        // OPERADORES ==  !=
        public static bool operator ==(Euro e, Dolar d)
        {
            //return e.cantidad == d.GetCantidad;
            // se puede hacer usando el casteo del Dolar a Euro
            return e == (Euro)d;
        }
        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e, Peso p)
        {
            //return e.cantidad == d.GetCantidad;
            // se puede hacer usando el casteo del Dolar a Euro
            return e == (Euro)p;
        }
        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }
        public static bool operator ==(Euro e1, Euro e2)
        {
            return e1.GetCantidad == e2.GetCantidad;
        }
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }

        // FIN OPERADORES ==  !=

        // OPERADORES + - 
        public static Euro operator +(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad + ((Euro)e).GetCantidad);
        }

        public static Euro operator +(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad + ((Euro)p).GetCantidad);
        }

        public static Euro operator -(Euro e, Dolar d)
        {
            return new Euro(e.GetCantidad - ((Euro)d).GetCantidad);
        }

        public static Euro operator -(Euro e, Peso p)
        {
            return new Euro(e.GetCantidad - ((Euro)p).GetCantidad);
        }

        // FIN OPERADORES + - 

    }
}
