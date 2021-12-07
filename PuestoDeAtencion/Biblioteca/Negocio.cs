using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Negocio
    {
        private PuestoAtencion caja;
        private Queue<Cliente> clientes;
        private string nombre;

        //El constructor privado inicializará la colección y el puesto de atención como Caja1.
        private Negocio()
        {
            this.clientes = new Queue<Cliente>();
            this.caja = new PuestoAtencion(PuestoAtencion.Puesto.Caja1);
        }

        public Negocio(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        //SOBRECARGAS

        //El operador + será el único capaz de agregar un Cliente a la cola de atención.
        //Sólo se agregará un Cliente si este no forma parte de la lista. Reutilizar el == de Cliente.

        public static bool operator +(Negocio n, Cliente c)
        {
            /*
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return false;
                }
            }
            n.clientes.Enqueue(c);
            return true;*/

            // lo hago de nuevo pero usando el != para saber si hay un cliente en el negocio
            if (n != c)
            {
                n.clientes.Enqueue(c);
                return true;
            }
            return false;
        }

        //La propiedad Cliente retornará el próximo cliente en la cola de atención en el get.
        //El set deberá controlar que el Cliente no figure en la cola de atención, caso contrario lo agregará.
        public Cliente Cliente
        {
            get
            {
                return clientes.Dequeue();
            }
            set
            {
                /*
                // this + value devuelve un bool, asique tengo que asignarlo a algo. 
                bool respuesta = this + value;
                */
                //Tambien se puede usar el operador de descarte
                _ = this + value;

            }
        }

        //El operador == retornará true si el cliente se encuentra en la colección.
        public static bool operator ==(Negocio n, Cliente c)
        {
            foreach (Cliente cliente in n.clientes)
            {
                if (cliente == c)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(Negocio n, Cliente c)
        {
            return !(n == c);
        }

        //El operador ~ generará una atención del próximo cliente en la cola,
        //utilizando la propiedad Cliente y el método Atender de PuestoAtencion.
        //Retornará true si pudo realizar la operación completa.
        public static bool operator ~(Negocio n)
        {
            if (n.clientes.Count > 0)
            {
                return n.caja.Atender(n.Cliente);
            }
            return false;
        }

        //La propiedad ClientesPendientes retornará la cantidad de clientes esperando a ser atendidos.
        public int ClientesPendientes
        {
            get
            {
                return this.clientes.Count;
            }
        }

    }
}
