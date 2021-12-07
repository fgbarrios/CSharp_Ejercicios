using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class PuestoAtencion
    {
        public enum Puesto
        { 
            Caja1,
            Caja2
        }
        //El atributo numeroActual es estático y privado.

        private static int numeroActual;
        private Puesto puesto;

        //La propiedad estática NumeroActual es la encargada de incrementar en 1 al atributo numeroActual y luego retornarlo.
        public static int NumeroActual
        {
            get 
            { 
                return ++PuestoAtencion.numeroActual;
            }
        }
        //Se inicializará en el constructor de clase(estático) con valor 0.
        static PuestoAtencion()
        {
            PuestoAtencion.numeroActual = 0;
        }

        public PuestoAtencion(Puesto puesto)
        {
            this.puesto = puesto;
        }

        //El método Atender simulará un tiempo de atención a un cliente:
        //recibirá un cliente, simulará un tiempo de atención mediante el método Sleep de la clase Thread
        //(perteneciente al espacio de nombre System.Threading)
        //y retornará true para indicar el final de la atención.
        public bool Atender(Cliente cli)
        {
            if (cli is not null)
            {
                Thread.Sleep(2000);
                return true;
            }
            return false;
        }
    }
}
