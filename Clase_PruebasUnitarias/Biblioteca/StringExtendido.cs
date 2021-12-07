using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    // deben ser clases estaticas para poder extenderlas
    public static class StringExtendido
    {
        public static int ContadorPalabras(this string palabra)
        {
            if (string.IsNullOrEmpty(palabra))
            {
                throw new ArgumentException();
            }
            // hay una sobrecarga del Split que recibe un array de caracteres a "splitear"
            return palabra.Split(new char[] {' ', '-'}, StringSplitOptions.RemoveEmptyEntries).Length;

        }

    }
}
