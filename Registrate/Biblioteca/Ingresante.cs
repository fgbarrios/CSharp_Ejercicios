using System;
using System.Text;

namespace Biblioteca
{
    public class Ingresante
    {
        private string[] cursos;
        private string direccion;
        private int edad;
        private string genero;
        private string nombre;
        private string pais;

        //El constructor inicializará todos los atributos de la clase.
        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos, int edad)
        {
            this.nombre = nombre;
            this.direccion = direccion;
            this.genero = genero;
            this.pais = pais;
            this.cursos = cursos;
            this.edad = edad;
        }

        //El método Mostrar expondrá todos los atributos de la clase al exterior, utilizar StringBuilder e interpolación de strings.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Direccion: {this.direccion}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Genero: {this.genero}");            
            sb.AppendLine($"Pais: {this.pais}");

            sb.AppendLine("Curso/s:");

            // uso Array.Reverse para mostrar los items en orden
            Array.Reverse(cursos);
            foreach (string item in cursos)
            {
                if (!(item is null))
                {
                    sb.AppendLine($" {item}");
                }

            }

            // se puede recorrer el listado de cursos con un for tambien
            /*for (int i = 0; i < cursos.Length; i++)
            {                
                if (!(cursos[i] is null))
                {                    
                    sb.AppendLine($" {cursos[i]}");
                }
                
            }*/

            return sb.ToString();

        }






    }
}
