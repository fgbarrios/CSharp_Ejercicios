using System;

namespace Biblioteca
{
    public class Cliente
    {
        private string nombre;
        private int numero;

        // PROPIEDADES
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public int Numero 
        {
            get
            {
                return this.numero;
            }
        }

        // CONSTRUCTORES
        public Cliente(int numero)
        {
            this.numero = numero;
        }
        public Cliente(int numero, string nombre)
            :this(numero)
        {
            this.nombre = nombre;
        }

        // SOBRECARGAS

        //La sobrecarga del operador == retornará true si dos clientes tienen el mismo número.
        public static bool operator ==(Cliente c1, Cliente c2)
        {
            return c1.numero == c2.numero;       
        }
        public static bool operator !=(Cliente c1, Cliente c2)
        {
            return !(c1 == c2);
        }

    }
}
