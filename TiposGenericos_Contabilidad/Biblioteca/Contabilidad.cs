using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Contabilidad<T,U> 
        where T: Documento  //Tanto el tipo genérico T como el U deberán ser del tipo Documento o uno de sus derivados.
        where U : Documento, new() //El tipo U deberá tener una restricción que indique que deberá tener un constructor público y sin parámetros.
    {
        public List<T> egresos;
        public List<U> ingresos;

        //Crear en Contabilidad un constructor que no reciba parámetros e inicialice las listas.
        public Contabilidad()
        {
            this.egresos = new List<T>();
            this.ingresos = new List<U>();
        }

        public Contabilidad(List<T> egresos, List<U> ingresos)
            :this()
        {
            this.egresos = egresos;
            this.ingresos = ingresos;
        }

        //El operador + entre Contabilidad y T agrega un elemento a la lista egresos.
        public static Contabilidad<T,U> operator +(Contabilidad<T, U> libroContable, T egreso )
        {
            libroContable.egresos.Add(egreso);
            return libroContable;
        }
        //El operador + entre Contabilidad y U agrega un elemento a la lista ingresos.
        public static Contabilidad<T, U> operator +(Contabilidad<T, U> libroContable, U ingreso)
        {
            libroContable.ingresos.Add(ingreso);
            return libroContable;
        }

    }
}
