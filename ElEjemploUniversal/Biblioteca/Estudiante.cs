using System;
using System.Text;

namespace Biblioteca
{
    public class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        //Tendrá un constructor estático que inicializará el atributo estático random.
        static Estudiante()
        {
            random = new Random();
        }

        //Tendrá un constructor de instancia que inicializará los atributos nombre, apellido y legajo.
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }

        #region "SETTERS"

        //El método setter SetNotaPrimerParcial permitirá cambiar el valor del atributo notaPrimerParcial.
        public void SetNotaPrimerParcial(int nota)
        {
            this.notaPrimerParcial = nota;
        }

        //El método setter SetNotaSegundoParcial permitirá cambiar el valor del atributo notaSegundoParcial.
        public void SetNotaSegundoParcial(int nota)
        {
            this.notaSegundoParcial = nota;
        }
        #endregion

        #region "METODOS"


        //El método privado CalcularPromedio retornará el promedio de las dos notas.
        private float CalcularPromedio()
        {
            return (float)(this.notaPrimerParcial + this.notaSegundoParcial) / 2;
        }

        //El método CalcularNotaFinal deberá retornar la nota del final con un numero aleatorio entre 6 y 10 incluidos siempre
        //y cuando las notas del primer y segundo parcial sean mayores o iguales a 4,
        //caso contrario la inicializará con el valor -1.
        public int CalcularNotaFinal() 
        {
            int resultado = -1;
            if (this.notaPrimerParcial >= 4 && this.notaSegundoParcial >= 4)
            {
                resultado = random.Next(6,11);
            }

            return resultado;
        }

        //El método Mostrar utilizará StringBuilder para armar una cadena de texto con todos los datos de los alumnos:
        //Nombre, apellido y legajo.
        //Nota del primer y segundo parcial.
        //Promedio.
        //Nota final.Se mostrará sólo si el valor es distinto de -1, caso contrario se mostrará la leyenda "Alumno desaprobado".

        public string Mostrar() 
        {
            StringBuilder sb = new StringBuilder();
            int notaFinal = CalcularNotaFinal();

            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Apellido: {this.apellido}");
            sb.AppendLine($"Legajo: {this.legajo}");

            sb.AppendLine($"Nota del primer parcial: {this.notaPrimerParcial}");
            sb.AppendLine($"Nota del segundo parcial: {this.notaSegundoParcial}");

            sb.AppendLine($"Promedio: {CalcularPromedio()}");
                     
            if (notaFinal != -1)
            {
                sb.AppendLine($"Nota Final: {notaFinal}");
            }
            else {
                sb.AppendLine("Alumno desaprobado.");
            }

            return sb.ToString();
        }

        #endregion

    }
}
