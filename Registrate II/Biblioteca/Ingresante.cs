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

        public Ingresante(string nombre, string direccion, string genero, string pais, string[] cursos,  int edad)
        {
            this.nombre = nombre;            
            this.direccion = direccion;
            this.genero = genero;
            this.edad = edad;
            this.pais = pais;
            this.cursos = cursos;
        }

        //El método Mostrar expondrá todos los atributos de la clase al exterior, utilizar StringBuilder e interpolación de strings.
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Dirección: {this.direccion}");
            sb.AppendLine($"Genero: {this.genero}");
            sb.AppendLine($"Edad: {this.edad}");
            sb.AppendLine($"Pais: {this.pais}");
            sb.AppendLine($"Cursos: ");

            foreach (string item in this.cursos)
            {
                sb.AppendLine($"{item}");
            }
            return sb.ToString();    
        }

    }
}
