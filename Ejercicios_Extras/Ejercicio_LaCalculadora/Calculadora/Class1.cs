using System;

namespace Biblioteca
{
    //Calcular (público): Recibirá tres parámetros, el primer operando,
    //el segundo operando y la operación matemática.
    //El método devolverá el resultado de la operación.

    //Validar(privado) : Recibirá como parámetro el segundo operando.
    //Este método se debe utilizar sólo cuando la operación elegida sea la DIVISIÓN.
    //Este método devolverá true si el operando es distinto de cero.
    public class Calculadora
    {
        public static float Calcular(int uno, int dos, char operacion)
        {
            switch (operacion)
            {
                case '+':
                    return uno + dos;
                    break;

                case '-':
                    return uno - dos;
                    break;

                case '*':
                    return uno * dos;
                    break;

                case '/':
                    if (Validar(dos))
                    {
                        return uno / dos;
                    }
                    return -1;
                    break;
                default:
                    return -1;
                    break;
            }

        }

        private static bool Validar(int dos) 
        {
            if (dos != 0)
            {
                return true;
            }
            return false;
        }
    }
}
