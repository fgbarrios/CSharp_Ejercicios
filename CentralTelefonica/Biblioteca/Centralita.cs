using System;
using System.Collections.Generic;
using System.Text;

namespace Biblioteca
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;

        //La lista sólo se inicializará en el constructor por defecto Centralita.
        private Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }
        public Centralita(string razonSocial)
            :this()
        {
            this.razonSocial = razonSocial;
        }

        // PROPIEDADES
        //Las propiedades GananciaPorTotal, GananciaPorLocal y GananciaPorProvincial retornarán el precio de lo facturado
        //según el criterio (llamada local, provincial o todas).
        //Dichos valores se calcularán en el método CalcularGanancia.
        public float GananciasPorLocal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Local); }

        }
        public float GananciasPorProvincial
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Provincial); }
        }
        public float GananciasPorTotal
        {
            get { return CalcularGanancia(Llamada.ETipoLlamada.Todas); }
        }

        public List<Llamada> Llamadas
        {
            get { return this.listaDeLlamadas; }
        }

        // FIN PROPIEDADES

        //CalcularGanancia será privado.
        //Este método recibe un enumerado TipoLlamada y retornará el valor de lo recaudado,
        //según el criterio elegido (ganancias por las llamadas del tipo Local, Provincial o de Todas según corresponda).
        private float CalcularGanancia(Llamada.ETipoLlamada tipo)
        {
            float resultado = 0;
            foreach (Llamada item in this.Llamadas)
            {
                switch (tipo)
                {
                    case Llamada.ETipoLlamada.Local:
                        if (item is Local)
                        {
                            resultado += ((Local)item).CostoLlamada;
                        }
                        break;
                    case Llamada.ETipoLlamada.Provincial:
                        if(item is Provincial)
                        {
                            resultado += ((Provincial)item).CostoLlamada;
                        }
                        break;
                    case Llamada.ETipoLlamada.Todas:
                        if (item is Provincial)
                        {
                            resultado += ((Provincial)item).CostoLlamada;
                        }else if (item is Local)
                        {
                            resultado += ((Local)item).CostoLlamada;
                        }
                        break;
                }            
            }
            return resultado;
        }

        //El método Mostrar expondrá la razón social,
        //la ganancia total,
        //ganancia por llamados locales y provinciales
        //y el detalle de las llamadas realizadas.

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"--------------Listado de Llamadas-------------");
            sb.AppendLine($"Razon Social: {this.razonSocial}");
            sb.AppendLine($"Ganancia Total: {GananciasPorTotal.ToString()}");
            sb.AppendLine($"Ganancia por llamadas locales: {GananciasPorLocal.ToString()}");
            sb.AppendLine($"Ganancia por llamadas provinciales: {GananciasPorProvincial.ToString()}");

            int contador = 1;
            foreach (Llamada item in listaDeLlamadas)
            {
                sb.AppendLine($"Llamada {contador}");
                sb.AppendLine($"{item.Mostrar()}");
                contador++;
            }
            return sb.ToString();
        }

        public void OrdenarLlamadas()
        {
            listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

    }
}
