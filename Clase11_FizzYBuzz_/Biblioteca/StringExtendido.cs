using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class StringExtendido
    {
        public static string FizzBuzz(this int[] numero)
        {
            string[] respuesta = new string[21];

            for (int i = 0; i < numero.Length; i++)
            {
                if (((numero[i] % 3) == 0) && ((numero[i] % 5) == 0))
                {
                    respuesta[i] = "fizz buzz";
                }
                else if ((numero[i] % 5) == 0)
                {
                    respuesta[i] = "buzz";
                }
                else if ((numero[i] % 3) == 0)
                {
                    respuesta[i] = "fizz";
                }
                else {
                    respuesta[i] = numero[i].ToString();
                }
            }
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < respuesta.Length; i++)            
            {                
                sb.Append(respuesta[i]);

                if (i == (respuesta.Length - 1))
                {
                    sb.Append(".");
                }
                else
                {
                    sb.Append(", ");
                }
                
            }

            return sb.ToString();
        }

    }
}
