using System;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            int baseTriangulo;
            int altura;
            double hipotenusa;

            Console.WriteLine("Ingrese base (en cm):");
            baseTriangulo = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese altura (en cm):");
            altura = int.Parse(Console.ReadLine());

            hipotenusa = Calculo.LongitudHipotenusa(baseTriangulo, altura);

            Console.WriteLine($"La hipotenusa es {hipotenusa}");


        }
    }
}
