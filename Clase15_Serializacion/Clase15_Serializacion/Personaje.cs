using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Clase15_Serializacion
{
    [XmlInclude(typeof(Mago))] // se debe incluir cuando queremos serializar clases hijas
    [XmlInclude(typeof(Guerrero))] // se debe incluir cuando queremos serializar clases hijas
    public class Personaje
    {
        private int puntosDeVida;
        private string nombre;

        public Personaje()
        {

        }

        public Personaje(int puntosDeVida, string nombre)
        {
            this.puntosDeVida = puntosDeVida;
            this.nombre = nombre;
        }

        public int PuntosDeVida { get => puntosDeVida; set => puntosDeVida = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        public override string ToString()
        {
            return $"Nombre: {this.nombre} - Puntos de vida: {this.puntosDeVida}";
        }
    }
}
