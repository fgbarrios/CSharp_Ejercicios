using System;

namespace Biblioteca
{
    public class Boligrafo
    {
        private const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }

        #region "METODOS"
        //Generar los métodos getter GetColor y GetTinta para los correspondientes atributos (sólo retornarán el valor de los mismos).
        public ConsoleColor GetColor()
        {
            return this.color;
        }
        public short GetTinta()
        {
            return this.tinta;
        }

        //Generar un método setter privado SetTinta que valide el nivel de tinta y, si es válido, modifique el valor del atributo tinta.
        //El argumento tinta contedrá la cantidad de tinta a agregar o quitar. Podrá ser positivo (cargar tinta) o negativo (gastar tinta).
        //Se deberá validar que el nivel de tinta resultante sea mayor o igual a cero y menor o igual a cantidadTintaMaxima.
        //Si no es válido, no se deberá modificar el atributo ni realizar ninguna acción.
        private void SetTinta(short tinta)
        {
            if (tinta > 0)
            {
                if ((this.tinta + tinta) > cantidadTintaMaxima) // si la cantidad a cargar supera el maximo, asignamos el maximo.
                {
                    this.tinta = cantidadTintaMaxima;
                }
                else
                {
                    this.tinta += tinta;
                }
                
            }
            else if (tinta < 0)
            {
                if ((this.tinta + tinta) < 0) // si la cantidad a restar supera lo que hay de tinta, lo dejamos vacio.
                {
                    this.tinta = 0;
                }
                else {
                    this.tinta += 0; // sumamos ya que estaria recibiendo un valor negativo!!
                }
            } 

        }

        //El método Recargar colocará la tinta en su nivel máximo. Reutilizar código.
        public void Recargar()
        {
            SetTinta(cantidadTintaMaxima);
        }

        //El método Pintar restará la tinta gastada (reutilizar código).
        //El parámetro gasto representará la cantidad de unidades de tinta a utilizar
        //y utilizará tanta tinta como tenga disponible sin quedar en negativo.
        //Utilizando el parámetro dibujo informará el resultado retornando tantos
        //* como unidades de tinta haya gastado, por ejemplo:
        //Si no había nada de tinta retornará una cadena de texto vacía.
        //Si el nivel de tinta era 10 y la cantidad a gastar 2, entonces retonará **.
        //Si el nivel de tinta era 3 y la cantidad a gastar 10, entonces retornará ***.

        public bool Pintar(short gasto, out string dibujo)
        {
            bool resultado = false;
            dibujo = "";
            string cadenaAux = "";
            short tintaActual = GetTinta();

            if (gasto > 0)
            {
                while (gasto > 0 && tintaActual > 0)
                {
                    cadenaAux += "*";
                    tintaActual--;
                    gasto--;
                }
                dibujo = cadenaAux;
                this.tinta = tintaActual;
            }

            return resultado;
        }




        #endregion


    }
}
