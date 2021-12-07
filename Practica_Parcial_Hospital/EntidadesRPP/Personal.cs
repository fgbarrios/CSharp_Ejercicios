using System;
using System.Text;

namespace EntidadesRPP
{
    public abstract class Personal
    {
        protected string apellido;
        protected DateTime horarioEntrada;
        protected int legajo;

        protected Personal(string apellido, int legajo)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.horarioEntrada = DateTime.Now;
        }

        protected Personal(string apellido, int legajo, DateTime horarioEntrada)
            : this(apellido, legajo)
        {
            this.horarioEntrada = horarioEntrada;
        }

        //PROPIEDADES

        public string Apellido
        {
            get
            {
                return this.apellido;
            }
        }
        public abstract string Info
        {
            get;
        }
        public DateTime Ingreso
        {
            get
            {
                return this.horarioEntrada;
            }
        }
        public int Legajo
        {
            get
            {
                return this.legajo;
            }
        }

        /*Método de instancia (protegido y virtual) ArmarInfo: retornará el apellido y el legajo del personal con el siguiente
        formato: Pérez, legajo: 24, siendo Pérez el apellido del personal y 24 su número de legajo. Se relacionará con la
        propiedad abstracta.*/
        protected virtual string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Apellido}, legajo: {Legajo}");
            return sb.ToString();

        }

        /*Polimorfismo en ToString, retornará una cadena conteniendo el apellido y el legajo del personal (reutilizar código) y su
        horario de ingreso, respetando el siguiente formato: Pérez, legajo: 24 - ingreso: 09:12:18 hs., siendo Pérez el apellido
        del personal, 24 su número de legajo y 09:12:18 la hora, minutos y segundos de su horario de ingreso (utilizar método
        ToLongTimeString, del atributo de tipo DateTime.
         * */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(ArmarInfo());
            sb.Append($"- Ingreso: {Ingreso.ToLongTimeString()}");

            return sb.ToString();
        }

        /*Sobrecarga de operadores:
        Explícito. Retornará el legajo (en formato de cadena de texto) del personal que recibe como parámetro.
        Igualdad (==) (Personal, Personal). Retornará true, si los apellidos y los legajos son iguales, false, caso contrario.
        Reutilizar código.
         */
        public static explicit operator string(Personal p)
        {
            return p.Legajo.ToString();
        }

        public static bool operator ==(Personal p1, Personal p2)
        {
            if (p1.Legajo == p2.Legajo && p1.Apellido.Equals(p2.Apellido))
            {
                return true;
            }
            return false;
        }
        public static bool operator !=(Personal p1, Personal p2)
        {
            return !(p1 == p2);
        }

        /*OrdenarPorLegajoASC y OrdenarPorLegajoDESC: Establecerán el criterio de comparación 
        entre los objetos de tipo Personal que reciben cómo parámetros. Reutilizar cógigo.
        Estos métodos se utilizarán para ordenar listas genéricas (método Sort).
         * */
        public static int OrdenarPorLegajoASC(Personal p1, Personal p2)
        {
            if (p1.Legajo > p2.Legajo)
            {
                return 1;
            }
            else if (p1.Legajo < p2.Legajo)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

        public static int OrdenarPorLegajoDESC(Personal p1, Personal p2)
        {
            return (OrdenarPorLegajoASC(p1, p2)) * -1;
        }


    }
}
