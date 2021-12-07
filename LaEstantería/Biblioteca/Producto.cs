using System;
using System.Text;

namespace Biblioteca
{
    public class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        //Posee sólo un constructor de instancia.
        public Producto(string marca, string codigoDeBarra, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }

        //El método GetMarca, retornará el valor correspondiente al atributo marca.
        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        //El método de clase (estático) MostrarProducto es público y retornará una cadena detallando los atributos de la clase.
        public static string MostrarProducto(Producto p)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Codigo de Barra: {(string)p}");
            sb.AppendLine($"Marca: {p.marca}");
            sb.AppendLine($"Precio: {p.precio}");

            return sb.ToString();

        }

        // SOBRECARGAS
        //explicit: Realizará la conversión de un objeto Producto a string. Sólo retornará el atributo codigoDeBarras del producto.
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }

        //== (Producto, Producto): Retornará true si las marcas y códigos de barra son iguales, false caso contrario.
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return (p1.codigoDeBarra == p2.codigoDeBarra && p1.marca == p2.marca);
            }
            return false;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            return !(p1 == p2);
        }

        //== (Producto, string): Retornará true si la marca del producto coincide con la cadena pasada como argumento, false caso contrario.
        public static bool operator ==(Producto p1, string marca)
        {
            if (p1.marca == marca)
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Producto p1, string marca)
        {
            return !(p1 == marca);
        }
    }
}
