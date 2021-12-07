using System;

namespace Ejercicio08
{
    class Ejercicio_08
    {
        /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas 
         * en el mes de N empleados de una fábrica.
         Se pide calcular el importe a cobrar teniendo en cuenta que el total 
        (que resulta de multiplicar el valor hora por la cantidad de horas trabajadas), 
        hay que sumarle la cantidad de años trabajados multiplicados por $ 150, 
        y al total de todas esas operaciones restarle el 13% en concepto de descuentos. 
        Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, 
        el total a cobrar en bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados. 
        Nota: Utilizar estructuras repetitivas y selectivas.
         * 
         * */
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro. 08";           

            bool confirmar = true;

            while (confirmar)
            {
                Recibos.CargarYMostrarDatos();

                Console.WriteLine("Desea continuar ingresando empleados? s / n: ");
                char confirmacion = (char)Console.Read();
                if (confirmacion == 'n')
                {
                    confirmar = false;
                }
            }           

            Console.ReadKey();
        }
    }
}
