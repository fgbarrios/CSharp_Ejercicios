using System;

namespace Biblioteca
{
    public class Validador
    {
        public static bool ValidarRespuesta(char respuesta)
        {
            if (respuesta == 'S')
            {
                return true;
            }
            return false;

        }

    }
}
