using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08
{
    class Recibos
    {
        public static void CargarYMostrarDatos() 
        {
            int valorHora;
            string nombre;
            int anios;
            int cantidadHorasTrabajadasMes;

            Console.WriteLine("Ingrese nombre del empleado:");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese valor hora:");
            valorHora = int.Parse(Console.ReadLine());            

            Console.WriteLine("Ingrese antiguedad (en años):");
            anios = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese cantidad de hs trabajadas en el mes:");
            cantidadHorasTrabajadasMes = int.Parse(Console.ReadLine());

            CalcularReciboYMostrar(valorHora, nombre, anios, cantidadHorasTrabajadasMes);

        }


        /*Se pide calcular el importe a cobrar teniendo en cuenta que el total
         * (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
         * hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
         * y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 
         * Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
         * el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
         * * */
        private static void CalcularReciboYMostrar(int valorHora, string nombre, int anios, int cantidadHorasTrabajadas) 
        {
            float total;
            float totalBruto;
            float descuentos;
            int totalAnios;

            totalBruto = valorHora * cantidadHorasTrabajadas;
            totalAnios = anios * 150;
            totalBruto += totalAnios;

            // resto el 13% al total
            descuentos = totalBruto * 13 / 100;

            total = totalBruto - descuentos;

            // muestro el recibo
            Console.WriteLine("---Recibo Empleado---");
            Console.WriteLine($"Nombre: {nombre}");
            Console.WriteLine($"Antiguedad: {anios} años");
            Console.WriteLine($"Valor Hora: {valorHora}");
            Console.WriteLine($"Total a cobrar en bruto: {totalBruto}");
            Console.WriteLine($"Total Descuentos: {descuentos}");
            Console.WriteLine($"Total Neto a cobrar: {total}");
            Console.WriteLine("");

        }
    }
}
