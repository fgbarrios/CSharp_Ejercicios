using System;
using System.Text;

namespace Biblioteca
{
    public class Cuenta
    {
        private string titular;
        private decimal cantidad;

        //Un constructor que permita inicializar todos los atributos.
        public Cuenta(string titular, decimal cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        //Un método getter para cada atributo.
        public string GetTitular()
        {
            return this.titular;
        }
        public decimal GetCantidad()
        {
            return this.cantidad;
        }

        // METODOS
        // mostrar retornará una cadena de texto con todos los datos de la cuenta.

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Titular: {GetTitular()}, Cantidad: {GetCantidad()}");

            return sb.ToString();
        
        }

        //ingresar recibirá un monto para acreditar a la cuenta. Si el monto ingresado es negativo, no se hará nada.
        public void Ingresar(decimal cantidadAIngresar)
        {
            if (cantidadAIngresar != 0)
            {
                this.cantidad += cantidadAIngresar;
            }
        }

        //retirar recibirá un monto para debitar de la cuenta. La cuenta puede quedar en negativo.
        public void Retirar(decimal cantidadARetirar)
        {
            this.cantidad -= cantidadARetirar;            
        }


    }
}
