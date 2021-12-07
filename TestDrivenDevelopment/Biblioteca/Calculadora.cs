using System;

namespace Biblioteca
{
    public class Calculadora
    {
        //Crear una calculadora de string con un método int Add (string numeros)
        //y automatizar las pruebas unitarias para cada uno de los siguientes puntos.
        /*
        public int Add(string numeros)
        {
            //Parte 1
            //El método Add debe poder tomar hasta dos números separados por comas, y devolverá su suma.
            //Por ejemplo "" o "1" o "1,2" como entradas(para un string vacío devolverá 0).
            int cantidadCaracteres = numeros.Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries).Length;
                       
            int sumatoria = 0;

            if (cantidadCaracteres > 1)
            {
                string[] variosCaracteresString = numeros.Split(new char[] { ' ', ',', }, StringSplitOptions.RemoveEmptyEntries);
                int[] variosCaracteres = new int[cantidadCaracteres];
                for (int i = 0; i < cantidadCaracteres; i++)
                {
                    if (numeros[i] == ' ')
                    {
                        variosCaracteres[i] = 0;
                    }
                    else
                    {
                        variosCaracteres[i] = int.Parse(variosCaracteresString[i]);
                    }
                    
                }

                for (int i = 0; i < variosCaracteres.Length; i++)
                {
                    sumatoria += variosCaracteres[i];
                }
            }
            else
            {
                if (numeros[0] == ' ')
                {
                    sumatoria = 0;
                }
                sumatoria = int.Parse(numeros);

            }
            return sumatoria;

        }
        */
    }
}
