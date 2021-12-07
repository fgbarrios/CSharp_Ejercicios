using System;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDiasVividos;
            DateTime fechaIngresada = new DateTime();
            string fechaIng;

            Console.WriteLine("Ingrese fecha de nacimiento (año/mes/dia):");
            fechaIng = Console.ReadLine();
            fechaIngresada = DateTime.Parse(fechaIng);

            cantidadDiasVividos =  NumeroDiasVividos(fechaIngresada);

            Console.WriteLine($"La cantidad de dias vividos es de: {cantidadDiasVividos}");
        }


        static int NumeroDiasVividos(DateTime fecha) 
        {
            int dias = 0;
            DateTime fechaActual = new DateTime();
            fechaActual = DateTime.Now;

            dias = (fechaActual - fecha).Days;

            return dias;
            
        } 
    }
}
