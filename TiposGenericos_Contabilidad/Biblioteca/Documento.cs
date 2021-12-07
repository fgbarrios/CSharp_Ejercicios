using System;

namespace Biblioteca
{
    public class Documento
    {
        private int documento;

        public Documento(int documento)
        {
            this.documento = documento;
        }
        public int Numero { get { return this.documento; } }

    }
}
