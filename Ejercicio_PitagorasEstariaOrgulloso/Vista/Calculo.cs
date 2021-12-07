using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vista
{
    class Calculo
    {
        public static double LongitudHipotenusa(int baseTri, int altura)
        {
            double resultado = 0;
            double potenciaBase;
            double potenciaAltura;

            potenciaBase = Math.Pow(baseTri, 2);

            potenciaAltura = Math.Pow(altura, 2);

            resultado = Math.Sqrt(potenciaAltura + potenciaBase);

            return resultado;
        }
    }
}
