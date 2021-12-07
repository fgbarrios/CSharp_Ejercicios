using System;

namespace Billetes
{
    public class Peso
    {
        //1 Euro equivale a 1,17 Dólares y 1 Dólar equivale a 102,65 Pesos.
        private double cantidad;
        private static double cotzRespectoDolar;

        static Peso()
        {
            Peso.cotzRespectoDolar = 1 / 102.65;
        }

        public Peso(double cantidad)
        {
            this.cantidad = cantidad;
        }
        public Peso(double cantidad, double cotizacion)
            : this(cantidad)
        {
            Peso.cotzRespectoDolar = cotizacion;
        }
        // PROPIEDADES
        public double GetCantidad
        {
            get { return this.cantidad; }
        }
        public static double GetCotizacion
        {
            get { return Peso.cotzRespectoDolar; }
        }

        // OPERADORES EXPLICITOS E IMPLICITOS
        public static explicit operator Dolar(Peso p)
        {
            return new Dolar(p.cantidad / Peso.GetCotizacion);
        }
        public static explicit operator Euro(Peso p)
        {
            return (Euro)((Dolar)p);
        }
        public static implicit operator Peso(double d)
        {
            return new Peso(d);
        }
        // FIN OPERADORES EXPLICITOS E IMPLICITOS

        // OPERADORES ==  !=
        public static bool operator ==(Peso p, Dolar d)
        {
            //return e.cantidad == d.GetCantidad;
            // se puede hacer usando el casteo del Dolar a Euro
            return p == (Peso)d;
        }
        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p, Euro e)
        {
            //return e.cantidad == d.GetCantidad;
            // se puede hacer usando el casteo del Dolar a Euro
            return p == (Peso)e;
        }
        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }
        public static bool operator ==(Peso p1, Peso p2)
        {
            return p1.GetCantidad == p2.GetCantidad;
        }
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }

        // FIN OPERADORES ==  !=

        // OPERADORES + - 
        public static Peso operator +(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad + ((Peso)d).GetCantidad);
        }

        public static Peso operator +(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad + ((Peso)e).GetCantidad);
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            return new Peso(p.GetCantidad - ((Peso)d).GetCantidad);
        }

        public static Peso operator -(Peso p, Euro e)
        {
            return new Peso(p.GetCantidad - ((Peso)e).GetCantidad);
        }

        // FIN OPERADORES + - 

    }
}
