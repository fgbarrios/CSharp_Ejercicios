using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Competencia
    {
        public enum ETipoCompetencia
        { 
            F1, MotoCross
        }

        private short cantidadCompetidores;
        private short cantidadVueltas;
        private List<VehiculoDeCarrera> competidores;
        private ETipoCompetencia tipo;

        //El constructor privado será el único capaz de inicializar la lista de competidores.
        private Competencia()
        {
            this.competidores = new List<VehiculoDeCarrera>();
        }
        public Competencia(short cantidadVueltas, short cantidadCompetidores, ETipoCompetencia tipo)
            :this()
        {
            this.cantidadCompetidores = cantidadCompetidores;
            this.cantidadVueltas = cantidadVueltas;
            this.tipo = tipo;
        }

        // PROPIEDADES
        public short CantidadCompetidores
        {
            get { return this.cantidadCompetidores; }
            set { this.cantidadCompetidores = value; }
        }
        public short CantidadVueltas
        {
            get { return this.cantidadVueltas; }
            set { this.cantidadVueltas = value; }
        }

        public VehiculoDeCarrera this[int i]
        {
            get { return this.competidores[i]; }
        }

        public ETipoCompetencia Tipo
        {
            get { return this.tipo; }
            set { this.tipo = value; }
        }


        public string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            
            sb.AppendLine("Competencia");
            sb.AppendLine($"Cantidad de vueltas: {this.cantidadVueltas.ToString()}");
            sb.AppendLine($"Maximo de competidores para esta competencia: {this.cantidadCompetidores.ToString()}");
            sb.AppendLine($"Cantidad actual de competidores: {this.competidores.Count}");

            foreach (VehiculoDeCarrera vehiculo in this.competidores)
            {
                //evaluo que tipo es Vehiculo y muestro segun cual es
                if (vehiculo.GetType() == typeof(AutoF1))
                {
                    sb.AppendLine(((AutoF1)vehiculo).MostrarDatos());
                }
                else if(vehiculo.GetType() == typeof(MotoCross))
                {
                    sb.AppendLine(((MotoCross)vehiculo).MostrarDatos());
                }                
            }

            return sb.ToString();
        }


        //La sobrecarga del operador + agregará un competidor si es que aún hay espacio(validar con cantidadCompetidores)
        //y el competidor no forma parte de la lista(== entre Competencia y AutoF1).
        public static bool operator +(Competencia c, VehiculoDeCarrera a)
        {
            Random random = new Random();

            //EXCEPCIONES
            //capturada dentro del operador + y
            //lanzada nuevamente como una nueva excepción con el mensaje "Competencia incorrecta".
            //Utilizar la propiedad InnerException para almacenar la excepción original.

            if (c is not null && a is not null)
            {
                try
                {
                    if (c.competidores.Count < c.cantidadCompetidores && c != a)
                    {
                        if (c.Tipo == Competencia.ETipoCompetencia.F1 && a.GetType() == typeof(AutoF1) ||
                            c.Tipo == Competencia.ETipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross))
                        {
                            //Al ser agregado, el competidor cambiará su estado enCompetencia a verdadero
                            a.EnCompetencia = true;
                            //la cantidad de vueltasRestantes será igual a la cantidadVueltas de Competencia
                            a.VueltasRestantes = c.cantidadVueltas;
                            //y se le asignará un número aleatorio entre 15 y 100 a cantidadCombustible.
                            a.CantidadCombustible = (short)random.Next(15, 101);

                            c.competidores.Add(a);
                            return true;

                        }

                    }
                }
                catch (CompetenciaNoDisponibleException ex)                
                {
                    throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia", "Competencia.cs", "operador +", ex);
                }

            }
            return false;

        }
        public static bool operator -(Competencia c, VehiculoDeCarrera a)
        {
            if (c is not null && a is not null)
            {
                if (c == a)
                {
                    c.competidores.Remove(a);
                    a.EnCompetencia = false;
                    a.VueltasRestantes = 0;
                    a.CantidadCombustible = 0;
                    return true;
                }
            }
            return false;
        }

        public static bool operator ==(Competencia c, VehiculoDeCarrera a)
        {
            if (c is not null && a is not null)
            {                
                foreach (VehiculoDeCarrera vehiculo in c.competidores)
                {
                    if (c.Tipo == Competencia.ETipoCompetencia.F1 && a.GetType() == typeof(AutoF1))
                    {
                        if ((AutoF1)a == (AutoF1)vehiculo)
                        {
                            return true;
                        }

                    }
                    else if (c.Tipo == Competencia.ETipoCompetencia.MotoCross && a.GetType() == typeof(MotoCross))
                    {
                        if ((MotoCross)a == (MotoCross)vehiculo)
                        {
                            return true;
                        }
                    }
                    else {
                        //La excepción CompetenciaNoDisponibleException será lanzada dentro del operador == de Competencia y Vehiculo
                        //con el mensaje "El vehículo no corresponde a la competencia"
                        throw new CompetenciaNoDisponibleException("El vehículo no corresponde a la competencia ==", "Competencia.cs", "operador ==");
                    }
                }
                                
            }
            return false;
        }

        public static bool operator !=(Competencia c, VehiculoDeCarrera a)
        {
            return !(c == a);
        }

    }
}
