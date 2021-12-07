using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Competencia competencia = new Competencia(5, 10);

            AutoF1 a1 = new AutoF1(1, "Ford");
            AutoF1 a2 = new AutoF1(4, "Chevrolet");
            AutoF1 a3 = new AutoF1(5, "Honda");
            AutoF1 a4 = new AutoF1(1, "Ford");
            AutoF1 a5 = new AutoF1(2, "Fiat");
            
            if (competencia + a1)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }

            Console.WriteLine("------------------------------");

            if (competencia + a2)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            Console.WriteLine("------------------------------");

            if (competencia + a3)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            Console.WriteLine("------------------------------");

            if (competencia + a4)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }
            Console.WriteLine("------------------------------");

            if (competencia + a5)
            {
                Console.WriteLine(competencia.MostrarDatos());
            }
            else
            {
                Console.WriteLine("NO SE AGREGO");
            }*/

            #region Instances
            Competencia granTurismo = new Competencia(5, 20, Competencia.ETipoCompetencia.F1);
            Competencia motoDakar = new Competencia(8, 10, Competencia.ETipoCompetencia.MotoCross);

            AutoF1 f1 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f2 = new AutoF1(1, "Ferrari", 500);
            AutoF1 f3 = new AutoF1(7, "McLaren", 510);

            MotoCross m1 = new MotoCross(1, "Honda", 160);
            MotoCross m2 = new MotoCross(1, "Honda", 160);
            MotoCross m3 = new MotoCross(69, "Yamaha", 159);

            string status;

            #endregion

            #region CompareCars

            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f1)
            {
                status = "Auto agregado";
            }
            else
            {
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            Console.WriteLine("----------- Insert New Car in F1 Competence -----------");
            //New Car into a car competence
            if (granTurismo + f3)
            {
                status = "Auto agregado";

            }
            else
            {
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f3.MostrarDatos());

            Console.WriteLine("----------- Insert Same Car in F1 Competence -----------");
            //Same Car into a car competence
            if (granTurismo + f2)
            {
                status = "Auto agregado";

            }
            else
            {
                status = "Vehiculo no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f2.MostrarDatos());

            Console.WriteLine("----------- Insert Motorcycle in F1 Competence -----------");

            if (granTurismo + m1)
            {
                status = "Moto agregada";
            }
            else
            {
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            #endregion

            # region ComparerMotorcycles

            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m1)
            {
                status = "Moto agregada";

            }
            else
            {
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m1.MostrarDatos());

            Console.WriteLine("----------- Insert New Moto in MotoCross Competence -----------");
            if (motoDakar + m3)
            {
                status = "Moto agregada";

            }
            else
            {
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m3.MostrarDatos());

            Console.WriteLine("----------- Insert Same Moto in MotoCross Competence -----------");
            if (motoDakar + m2)
            {
                status = "Moto agregada";

            }
            else
            {
                status = "Moto no agregada";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(m2.MostrarDatos());

            Console.WriteLine("----------- Insert Car in MotoCross Competence -----------");
            if (motoDakar + f1)
            {
                status = "Auto agregado";
            }
            else
            {
                status = "Auto no agregado";
            }
            Console.WriteLine($"{status} a la competencia");
            Console.WriteLine("Vehiculo:");
            Console.WriteLine(f1.MostrarDatos());

            #endregion

            #region ShowCompetencesData

            Console.WriteLine("----------- Data of Competences -----------");

            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            Console.WriteLine("Dakar MotoCross:");
            Console.WriteLine(motoDakar.MostrarDatos());

            #endregion
        }
    }
}
