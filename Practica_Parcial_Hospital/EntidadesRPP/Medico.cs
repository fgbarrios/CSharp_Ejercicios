using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public enum Especialidad 
    { 
        Cirujano,
        Pediatra,
        Clinico
    }

    public class Medico : Personal
    {
        protected Especialidad especialidad;

        public Medico(string apellido, int legajo, DateTime horarioEntrada, Especialidad especialidad)
            :base(apellido, legajo, horarioEntrada)
        {
            this.especialidad = especialidad;
        }

        public Especialidad Especialidad
        {
            get 
            {
                return this.especialidad;
            }
        }

        public override string Info 
        {
            get 
            {
                return this.ToString();
            }
        }

        /*Sobrescribir el método ArmarInfo para que retorne la siguiente cadena de texto:
        DOCTOR – Pérez, legajo: 24, especialidad: Pediatra, siendo Pérez el apellido, 24 su número de legajo y
        Pediatra la especialidad del médico.
         * */
        protected override string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"DOCTOR - {base.ArmarInfo()}, especialidad: {Especialidad}");

            return sb.ToString(); ;
        }

        /*Polimorfismo en ToString, retornará una cadena, respetando el siguiente formato:
        DOCTOR – Pérez, legajo: 24, especialidad: Pediatra - ingreso: 09:12:18 hs., siendo Pérez el apellido
        del personal, 24 su número de legajo, Pediatra la especialidad y 09:12:18 la hora, minutos y segundos
        del horario de ingreso del médico (utilizar método ToLongTimeString, del atributo de tipo DateTime).
         * */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ArmarInfo()} - Ingreso: {Ingreso.ToLongTimeString()}");

            return sb.ToString();
        }
    }
}
