using System;
using System.Collections.Generic;

namespace Biblioteca
{
    public class Libro
    {
        private List<string> paginas = new List<string>();

        public string this[int index]
        {
            get 
            {
                //El descriptor de acceso get del indexador leerá la página pedida,
                //siempre y cuando el subíndice se encuentre dentro de un rango correcto,
                //sino retornará un string vacío.

                if (index >= 0 && index < this.paginas.Count) {

                    return this.paginas[index].ToString();
                }
                else {
                    return "";
                }
            }
            set 
            {
                //En el set, si la página existe (existe ese índice) le asignará el texto.
                //Si no existe (si el índice es superior al máximo existente), agregará una nueva página.
                if (index >= 0 && index < this.paginas.Count)
                {
                    this.paginas[index] = value;
                }
                else
                {
                    // uso INSERT para sumar un nuevo valor a paginas
                    this.paginas.Add(value);
                }
            }
        }



    }
}
