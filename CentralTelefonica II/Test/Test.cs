using System;
using Biblioteca;

namespace Test
{
    class Test
    {
        static void Main(string[] args)
        {
            // Mi central
            Centralita c = new Centralita("Fer Center");

            // Mis llamadas
            Local l1 = new Local("Bernal", 30, "Rosario", 2.65f);
            Provincial prov2 = new Provincial("Morón", Provincial.Franja.Franja_1, 21, "Bernal");
            Local l3 = new Local("Lanús", 45, "San Rafael", 1.99f);
            Provincial prov4 = new Provincial(Provincial.Franja.Franja_3, prov2);
            Local test5 = new Local(l1, 10.10f);

            // Las llamadas se irán registrando en la Centralita.
            // La centralita mostrará por pantalla todas las llamadas según las vaya registrando.
            c += l1;
            c += prov2;
            c += l3;
            // los siguientes no se agregaran porque ya estan en la centralita (ver sobrecarga del == en Centralita)
            c += prov4;
            c += test5;

            Console.WriteLine("-------------------------------------");
            c.OrdenarLlamadas();
            Console.WriteLine(c.ToString());

            //Console.ReadKey();
        }
    }
}
