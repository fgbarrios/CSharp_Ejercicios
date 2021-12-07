using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesRPP
{
    public class MedicoEgresado : Medico
    {
        private DateTime horarioSalida;

        public MedicoEgresado(Medico medico)
            :base(medico.Apellido, medico.Legajo, medico.Ingreso, medico.Especialidad)
        {
            this.horarioSalida = DateTime.Now;
        }

        // PROPIEDADES

        public DateTime Egreso
        {
            get 
            {
                return this.horarioSalida;
            }
        }
        public override string Info
        {
            get
            {
                return this.ToString();
            }
        }

        public double Jornal
        {
            get 
            {
                return this.CalcularJornal();
            }
        }


        /*El método privado CalcularJornal, retornará el valor del jornal del médico egresado, para ello se deberá obtener la diferencia (horario de
        egreso menos horario de ingreso) y multiplicarlo según la especialidad, de acuerdo a la siguiente tabla de valores:
        Valor por segundo Especialidad
        $90,00              Cirujano
        $70,00               Clínico
        $40,00              Pediatra
         * */
        private double CalcularJornal()
        {
            TimeSpan dif = this.Egreso - this.horarioEntrada;
            double diferencia = (dif).TotalSeconds;

            int monto = 40;
            if (this.Especialidad == Especialidad.Cirujano)
            {
                monto = 90;
            }
            else if (this.Especialidad == Especialidad.Clinico)
            {
                monto = 70;
            }

            return diferencia * monto;
        }

        /*Sobrescribir el método ArmarInfo para que retorne la siguiente cadena de texto: 
         * DOCTOR – Pérez, legajo: 24, especialidad: Pediatra – JORNAL: $900,00 , 
         * siendo Pérez el apellido, 24 su número de legajo y Pediatra la especialidad del médico. Reutilizar código.
        Se deben mostrar sólo dos decimales en el valor del jornal.
         */
        protected override string ArmarInfo()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{base.ArmarInfo()} - JORNAL: ${Math.Round(this.Jornal, 2)}");

            return sb.ToString();
        }

        /*Polimorfismo en ToString, retornará una cadena, respetando el siguiente formato:
        DOCTOR – Pérez, legajo: 24, especialidad: Pediatra – JORNAL: $900,00 - ingreso: 09:12:18 hs. - egreso: 09:12:28 hs, 
        siendo Pérez el apellido del personal, 24 su número de legajo, Pediatra la especialidad, 09:12:18 la hora, minutos y segundos del horario de 
        ingreso del médico y 09:12:28 la hora, minutos y segundos del horario de egreso del médico (utilizar método ToLongTimeString, 
        del atributo de tipo DateTime). Reutilizar código.
         * */
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.ArmarInfo()} - Ingreso: {Ingreso.ToLongTimeString()}");

            return sb.ToString();
        }



    }
}
