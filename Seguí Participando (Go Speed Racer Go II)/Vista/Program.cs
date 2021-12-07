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

            Console.WriteLine("----------- Insertar Nuevo Auto en Competencia F1  -----------");
            // INSERTAR NUEVO AUTO
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            Console.WriteLine("----------- Insertar Nuevo Auto en Competencia F1  -----------");
            // INSERTAR NUEVO AUTO
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }            

            Console.WriteLine("----------- Insertar EL MISMO Auto en Competencia F1 -----------");
            // INSERTAR AUTO YA INGRESADO
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            Console.WriteLine("----------- Insertar MOTO en Competencia F1 -----------");
            // INSERTAR MOTO EN COMPETENCIA DE AUTO
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }            

            #endregion

            # region ComparerMotorcycles

            Console.WriteLine("----------- Insertar Nueva Moto en Competencia Motocross -----------");
            // INSERTAR MOTO EN COMPETENCIA MOTOCROSS
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }            

            Console.WriteLine("----------- Insertar Nueva Moto en Competencia Motocross  -----------");
            // INSERTAR MOTO EN COMPETENCIA MOTOCROSS
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            Console.WriteLine("----------- Insertar LA MISMA MOTO en Competencia Motocross  -----------");
            // INSERTAR MOTO YA INGRESADA EN COMPETENCIA MOTOCROSS
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            Console.WriteLine("----------- Insertar AUTO en Competencia Motocross -----------");
            // INSERTAR AUTO EN COMPETENCIA MOTOCROSS
            try
            {
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
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            

            #endregion

            #region ShowCompetencesData

            Console.WriteLine("----------- INFORMACION DE LAS COMPETENCIAS -----------");

            Console.WriteLine("Turismo Carretera:");
            Console.WriteLine(granTurismo.MostrarDatos());

            Console.WriteLine("Dakar MotoCross:");
            Console.WriteLine(motoDakar.MostrarDatos());

            #endregion
        }
    }
}
