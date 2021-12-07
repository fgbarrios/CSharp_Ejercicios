using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            //En el método Main, simular depósitos y extracciones de dinero de la cuenta,
            //e ir mostrando como va variando el saldo.

            Cuenta n1 = new Cuenta("Pedro Perez", 2000);
            Cuenta n2 = new Cuenta("Gaston Gonzalez", 8000);

            // muestro
            Console.WriteLine("Datos iniciales");
            Console.WriteLine(n1.Mostrar());
            Console.WriteLine(n2.Mostrar());

            // ingresos
            n1.Ingresar(1500);
            n2.Ingresar(3000);

            // muestro
            Console.WriteLine("Movimientos");
            Console.WriteLine(n1.Mostrar());
            Console.WriteLine(n2.Mostrar());

            // extracciones
            n1.Retirar(10500);
            n2.Retirar(3000);

            // muestro
            Console.WriteLine(n1.Mostrar());
            Console.WriteLine(n2.Mostrar());

        }
    }
}
