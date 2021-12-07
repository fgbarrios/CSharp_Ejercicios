using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class NegativoNoPermitidoException: Exception
    {
        public NegativoNoPermitidoException(string mensaje)
            :this(mensaje, null)
        {

        }
        public NegativoNoPermitidoException(string mensaje, Exception inner)
            :base(mensaje, inner)
        {

        }

    }
}
