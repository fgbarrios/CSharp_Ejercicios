using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Se le debe pedir al usuario que ingrese dos números
            //y la operación que desea realizar(ingresando el caracter +, -, *o /).
            //El usuario decidirá cuándo finalizar el programa.

            char respuesta = 's';
            int numero1;
            int numero2;
            char operacion;
            float resultado;

            while (respuesta == 's')
            {

                Console.WriteLine("Ingrese numero 1:");
                numero1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese numero 2:");
                numero2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese operación que desea realizar (+, -, *, /):");
                operacion = char.Parse(Console.ReadLine());

                resultado = Calculadora.Calcular(numero1, numero2, operacion);

                Console.WriteLine($"El resultado es: {resultado}");

                Console.WriteLine("Desea continuar realizando calculos? s/n");
                respuesta = char.Parse(Console.ReadLine());
            }
            
        }
    }
}
