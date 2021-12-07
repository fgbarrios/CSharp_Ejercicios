using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio07
{
    class Ejercicio_07
    {
        /*Hacer un programa que pida por pantalla la fecha de nacimiento de una persona (día, mes y año) 
         * y calcule el número de días vividos por esa persona hasta la fecha actual (tomar la fecha del sistema con DateTime.Now). 
         * Nota: Utilizar estructuras selectivas. Tener en cuenta los años bisiestos.
         * */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 07";

            string fecha;
            DateTime fechaActual = DateTime.Now;
            DateTime fechaIngresada;
            double cantidadDiasVividos;

            Console.WriteLine("Ingrese fecha de nacimiento: dd/mm/aaaa");
            fecha = Console.ReadLine();
            fechaIngresada = Convert.ToDateTime(fecha);

            cantidadDiasVividos = (fechaActual - fechaIngresada).TotalDays;
            Console.WriteLine($"La cantidad de dias vividos es: {cantidadDiasVividos}");

            Console.ReadKey();

        }
    }
}
