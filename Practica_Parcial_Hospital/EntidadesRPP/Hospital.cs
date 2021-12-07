using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class Hospital
    {
        private string nombre;
        private List<Personal> personal;

        private Hospital() 
        {
            this.personal = new List<Personal>();
        }
        private Hospital(string nombre)
            :this()
        {
            this.nombre = nombre;
        }

        // PROPIEDADES
        public int CantidadPersonal
        {
            get { return this.personal.Count; }
        }

        /*Será de sólo lectura y retornará al objeto de tipo Personal que se ubique en el índice recibido. 
         * Retornar null si el índice es negativo o mayor o igual a la cantidad de elementos actual.
          Reutilizar código.
         * */
        public Personal this[int indice]
        {
            get 
            {
                if (indice > (this.CantidadPersonal - 1))
                {
                    return null;
                }
                else
                {
                    return this.personal[indice];
                }
            }
        }

        /*Sobrecarga de operadores:
        Implícito, retornará una instancia de Hospital cuyo nombre coincida con el parámetro recibido. Reutilizar código.
         * */
        public static implicit operator Hospital(string nombre)
        { 
            return new Hospital(nombre);
        }
        //Pipe (|), retornará el valor del índice del objeto de tipo Personal, si es que el personal se encuentra en el hospital, -1, caso
        //contrario.Reutilizar código.
        public static int operator |(Hospital h, Personal p)
        {
            foreach (Personal item in h.personal)
            {
                if (item == p)
                {
                    return h.personal.IndexOf(item);
                }
            }
            return -1;
        }

        //Adición(+), si el personal no se encuentra en el hospital, lo agregará a la colección.Reutilizar código.
        public static Hospital operator +(Hospital h, Personal p)
        {
            if ((h | p) == -1)
            {
                h.personal.Add(p);
            }
            return h;
        }

        //Sustracción(-), si el personal se encuentra en el hospital, lo removerá según su índice.Reutilizar código.
        public static Hospital operator -(Hospital h, Personal p)
        {
            int indice = h | p;
            if (indice != -1)
            {
                h.personal.RemoveAt(indice);
            }
            return h;
        }

        /*Polimorfismo en ToString, retornará una cadena con toda la información del hospital, 
         * incluyendo el detalle (completo) de cada personal. Reutilizar código.
         * */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Empleados: {this.CantidadPersonal}");
            sb.AppendLine($"Datos:");
            foreach (Personal item in this.personal)
            {
                sb.AppendLine(item.Info);
            }

            return sb.ToString();
        }

    }
}
