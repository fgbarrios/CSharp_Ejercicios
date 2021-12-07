using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ExtensionClaseCalculadora
    {
        public static int Add(this string numeros)
        {
            //Parte 1
            //El método Add debe poder tomar hasta dos números separados por comas, y devolverá su suma.
            //Por ejemplo "" o "1" o "1,2" como entradas(para un string vacío devolverá 0).
            numeros = numeros.Replace("\n", "").Replace("\r", "");
            int cantidadCaracteres = numeros.Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries).Length;
            string[] palabraAEvaluar = numeros.Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries);
            int sumatoria = 0;            

            //Parte II
            //Permitir que el método Add maneje una cantidad desconocida de números.
              
            int[] variosCaracteres = new int[cantidadCaracteres];

            for (int i = 0; i < cantidadCaracteres; i++)
            {
                if (palabraAEvaluar[i] == " ")
                {
                    variosCaracteres[i] = 0;
                }
                else if(int.Parse(palabraAEvaluar[i]) < 0)
                {
                    throw new NegativoNoPermitidoException($"No se pueden utilizar numeros negativos: {palabraAEvaluar[i]}");
                }
                else
                {
                    variosCaracteres[i] = int.Parse(palabraAEvaluar[i]);
                }

            }

            for (int i = 0; i < variosCaracteres.Length; i++)
            {
                sumatoria += variosCaracteres[i];
            }
            
            return sumatoria;

        }

    }
}
