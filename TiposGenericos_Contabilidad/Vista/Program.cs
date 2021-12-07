using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear un proyecto de consola y generar el código necesario para probar dichas clases.
            Contabilidad<Factura, Recibo> contabilidad = new Contabilidad<Factura, Recibo>();

            Recibo r1 = new Recibo();
            Recibo r2 = new Recibo(2500);

            Factura f1 = new Factura(15);
            Factura f2 = new Factura(50);

            contabilidad += r1;
            contabilidad += r2;

            contabilidad += f1;
            contabilidad += f2;

            foreach (Factura item in contabilidad.egresos)
            {
                Console.WriteLine($"El numero de la factura es: {item.Numero}");
            }

            foreach (Recibo item in contabilidad.ingresos)
            {
                Console.WriteLine($"El numero de recibo es: {item.Numero}");
            }



        }
    }
}
