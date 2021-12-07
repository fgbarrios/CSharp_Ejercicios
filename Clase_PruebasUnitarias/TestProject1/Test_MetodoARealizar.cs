using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Biblioteca;

namespace TestProject1
{
    [TestClass]
    public class Test_MetodoARealizar
    {
        [TestMethod]
        //para el nombre del metodo: MetodoAEvaluar_PruebaARealizar_ResultadoEsperado
        public void ContadorPalabras_CuandoRecibeDosPalabras_DeberiaRetornarDos()
        {
            //Arrange
            string textoPrueba = "Hola mundo";
            int expected = 2; //el valor de retorno deberia llamarse "expected" por convencion

            //Act
            // aca se llama el metodo a probar
            int actual = textoPrueba.ContadorPalabras(); //"actual" es otra palabra por convencion

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            Assert.AreEqual(expected, actual);

            // para string se usa
            //StringAssert

            //para colecciones
            //CollectionAssert
        }

        [TestMethod]

        [ExpectedException(typeof(ArgumentException))] // se especifica la excepcion esperada. Tiene que ser el tipo especifico (No Exception)
        public void ContadorPalabras_CuandoRecibeStringVacio_DeberiaLanzarArgumentException()
        {
            //Arrange
            string prueba = string.Empty;

            //Act
            int actual = prueba.ContadorPalabras();

            //Assert
            // en este caso, el Assert se reemplaza por la excepcion indicada arriba del nombre del metodo.

        }

        [TestMethod]

        public void ContadorPalabras_CuandoRecibeDosPalabrasSeparadasPorGuion_DeberiaRetornarDos()
        {
            //Arrange
            string textoPrueba = "Hola-mundo";
            int expected = 2; 

            //Act
            // aca se llama el metodo a probar
            int actual = textoPrueba.ContadorPalabras(); 

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            Assert.AreEqual(expected, actual);

        }

    }
}
