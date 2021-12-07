using System;
using Biblioteca;

namespace Vista
{
    class Program
    {
        static void Main(string[] args)
        {
            //Crear tres instancias de la clase Estudiante (tres objetos) en el método Main.

            Estudiante e1 = new Estudiante("Arcoiris", "199012", "Juanito");
            Estudiante e2 = new Estudiante("Citric", "198525", "Naranjita");
            Estudiante e3 = new Estudiante("Exaltacion de la cruz", "194556", "Agua");

            //Cargar las notas del primer y segundo parcial a todos los alumnos. Dos deberán estar aprobados y uno desaprobado.

            e1.SetNotaPrimerParcial(7);
            e1.SetNotaSegundoParcial(7);

            e2.SetNotaPrimerParcial(9);
            e2.SetNotaSegundoParcial(8);

            e3.SetNotaPrimerParcial(4);
            e3.SetNotaSegundoParcial(3);

            //Mostrar los datos de todos los alumnos.

            Console.WriteLine(e1.Mostrar());
            Console.WriteLine(e2.Mostrar());
            Console.WriteLine(e3.Mostrar());

        }
    }
} 
