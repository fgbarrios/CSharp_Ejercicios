using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01_09
{
    class Sobrecargas
    {

        /* Sobrecarga de metodos, constructores, operadores e indexadores
         * 
         * Sobrecarga: bloques de codigo con el mismo nombre pero con caracteristicas unicas para que el compilador las pueda identificar
         * 
         * Sobrecarga de metodos: se sobrecargan cambiando los parametros (la cantidad de parametros, los tipos y/o el orden). 
         * 
         * 
         * */
        //atributos
        public int entero;
        public string cadena;

        // constructores
        public Sobrecargas() {
            this.entero = 99;
            this.cadena = "sin valor";
        }

        public Sobrecargas(int p) : this()
        {
            this.entero = p;
            // la cadena se carga cuando usamos this()
            //this.cadena = "sin valor"; 
        }

        public Sobrecargas(string p)
        {
            this.entero = 99;
            this.cadena = p;
        }

        public Sobrecargas(int p, string p1)
        {
            this.entero = p;
            this.cadena = p1;
        }

        public string Ver()
        {
            return this.cadena + " - " + this.entero.ToString();
        }

        /// metodos
        public static void MiMetodo()
        {
            Console.WriteLine("Sin parametros. ");
        }

        private static void MiMetodo(string p1)
        {
            Console.WriteLine("Con parametro string {0}.", p1);
        }

        private static void MiMetodo(int p1) // los nombres de los parametros pueden ser iguales, influye el tipo
        {
            Console.WriteLine("Con parametro int {0}.", p1);
        }

        private static void MiMetodo(int p1, float p2)
        {
            Console.WriteLine("Con parametro int {0} y float {1}.", p1, p2);
        }

        // misma que la anterior, cambiado el orden de los parametros
        private static void MiMetodo(float p2, int p1)
        {
            Console.WriteLine("Con parametro int {0} y float {1}.", p1, p2);
        }

        // modificador OUT
        private static string MiMetodo(out int p1)
        {
            p1 = 88;

            Sobrecargas.MiMetodo(p1);
            return "Retorno de metodo out";
        }


        static void Main(string[] args)
        {
            // constructor
            Sobrecargas obj1 = new Sobrecargas();
            Sobrecargas obj2 = new Sobrecargas(8);
            Sobrecargas obj3 = new Sobrecargas("otra cadena");
            Sobrecargas obj4 = new Sobrecargas(77, "cadena desde main");

            Console.WriteLine(obj1.Ver());



            // metodos
            Sobrecargas.MiMetodo();

            Sobrecargas.MiMetodo("Texto desde main");

            Sobrecargas.MiMetodo(5,3.2f); // al pasar float hay que castearlo. tambien se puede poner

            Sobrecargas.MiMetodo(3.2f, 5);

            // OUT
            int p1 = 12; // se debe pasar una variable, no valor literal
            string retorno;

            retorno = Sobrecargas.MiMetodo(out p1);

            Console.WriteLine(retorno);
            Console.ReadKey();
        }
    }
}
