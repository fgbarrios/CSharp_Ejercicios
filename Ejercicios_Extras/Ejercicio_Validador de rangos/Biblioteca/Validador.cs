using System;

namespace Biblioteca
{
    public static class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            //if (valor <= max && valor >= min)
            //{
            //    return true;
            //}
            //return false;

            // refactorizando el codigo de arriba quedaria asi:
            return valor <= max && valor >= min;
        }
    }
}
