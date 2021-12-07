using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        //El constructor de instancia privado será el único que incializará el array.
        //La sobrecarga pública del constructor inicializará la ubicación del estante,
        //recibiendo como parámetros la capacidad y la ubicación. Reutilizar código.
        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion)
            : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }

        //El método público GetProductos, retornará el array de productos.
        public Producto[] GetProductos()
        {
            return this.productos;
        }

        //El método público de clase (estático) MostrarEstante,
        //retornará una cadena con toda la información del estante incluyendo el detalle de cada uno de sus productos.
        //Reutilizar código.
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Estante ubicacion: {e.ubicacionEstante} \n");

            // recorro el listado de productos
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!Object.ReferenceEquals(e.productos[i], null)) // si no es NULL
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i])); // reutilizo MostrarProducto de Productos.cs
                    sb.AppendLine("----------------------");

                }
            }
            return sb.ToString();

        }

        // SOBRECARGAS
        //==: Retornará true si es que el producto ya se encuentra en el estante, false caso contrario.
        public static bool operator ==(Estante e, Producto p)
        {
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p) // si no es NULL
                {
                    return true;

                }
            }
            return false;
        }

        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }

        //+: Retornará true y agregará el producto si el estante posee capacidad de almacenar al menos un producto más
        //y dicho producto no se encuentra en el estante, false caso contrario.
        //Reutilizar código.
        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)
                    {
                        e.productos[i] = p;
                        return true;
                    }

                }
            }
            return false;
        }

        //-: Retornará un estante sin el producto, siempre y cuando el producto se encuentre en el listado. Reutilizar código.
        public static Estante operator -(Estante e, Producto p)
        {
            if (e == p)
	        {
                for (int i = 0; i < e.productos.Length; i++)
			    {
                    if (e.productos[i] == p)
	                {
                        e.productos[i] = null;
                        break;
	                }
			    }
	        }
            return e;
        }

    }
}
