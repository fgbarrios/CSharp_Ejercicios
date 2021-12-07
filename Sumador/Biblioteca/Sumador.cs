using System;
using System.Text;

namespace Biblioteca
{
    public class Sumador
    {
        private int cantidadSumas;

        //Sumador(int) inicializa cantidadSumas en el valor recibido por parámetro.
        public Sumador(int cantidadSumas)
        {
            this.cantidadSumas = cantidadSumas;
        }

        //Sumador() inicializa cantidadSumas en cero. Reutilizará al primer constructor.
        public Sumador() : this(0)
        {
            
        }

        //El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la siguiente lógica:
        //En el caso de Sumar(long, long) sumará los valores numéricos
        //En el de Sumar(string, string) concatenará las cadenas de texto.

        public string Sumar(string a, string b)
        {
            this.cantidadSumas++;
            StringBuilder sb = new StringBuilder();

            sb.Append($"{a}{b}");
            return sb.ToString();          
            
        }
        public long Sumar(long a, long b)
        {
            this.cantidadSumas++;
            return a + b;
        }

        //SOBRECARGAS

        // Generar una conversión explícita que retorne cantidadSumas.
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }

        //Sobrecargar el operador + (suma) con dos operadores de tipo Sumador.
        //El resultado será un long correspondiente al resultado de la suma del atributo cantidadSumas de cada argumento.
        public static long operator +(Sumador s1, Sumador s2) 
        {
            //utilizo la conversion explicita
            return (int)s1 + (int)s2;
        }

        //Sobrecargar el operador | (pipe) con dos operadores de tipo Sumador.
        //Deberá retornar true si ambos sumadores tienen igual valor en el atributo cantidadSumas.
        public static bool operator |(Sumador s1, Sumador s2)
        {
            //utilizo la conversion explicita
            if ((int)s1 == (int)s2)
            {
                return true;
            }
            return false;
        }

    }
}
