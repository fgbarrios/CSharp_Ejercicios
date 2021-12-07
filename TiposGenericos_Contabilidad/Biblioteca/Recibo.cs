using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Recibo : Documento
    {
        //El constructor sin parámetros de Recibo asignará 0 como número de documento.
        public Recibo()
            :this(0)
        {

        }
        public Recibo(int numero)
            :base(numero)
        {

        }

    }
}
