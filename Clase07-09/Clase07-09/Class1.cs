using System;

namespace Numero
{
    public class Numero
    {
        public double valor;

        public Numero(double valor)
        {
            this.valor = valor;
        }

        #region sobrecarga de operadores

        #region igualdad

        public static bool operator ==(Numero n1, Numero n2)
        {
            return n1.valor == n2.valor;
        }

        public static bool operator !=(Numero n1, Numero n2)
        {
            return !(n1 == n2);
        }

        public static bool operator ==(Numero n1, Double n2)
        {
            return n1.valor == n2;
        }

        public static bool operator !=(Numero n1, Double n2)
        {
            return !(n1.valor == n2);
        }



    }
}
