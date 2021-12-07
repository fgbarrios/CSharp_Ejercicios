using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Test_TestDrivenDevelopment
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Add_DebePoderTomarHastaDosNumerosSeparadosPorComas_DebeDevolverLaSuma()
        {
            //Arrange
            string numeros = "1,2";
            int expected = 3;            

            //Act
            int resultado = numeros.Add();

            //Assert
            Assert.AreEqual(resultado, expected);

        }

        //Permitir que el método Add maneje una cantidad desconocida de números.
        [TestMethod]
        public void Add_TomandoNCantidadDeNumeros_DebeDevolverLaSumaDeTodosLosNumeros()
        {
            //Arrange
            string numeros = "1,2,4,5,8,9";
            int expected = 29;

            //Act
            int resultado = numeros.Add();

            //Assert
            Assert.AreEqual(resultado, expected);

        }

        //Parte III#
        //Permita que el método Add admita salto de línea entre números(en lugar de comas).
        //La siguiente entrada está bien: "1 \ n2,3" (será igual a 6).
        //La siguiente entrada NO está bien: "1, \ n" (no es necesario probarlo, solo se aclara)
        [TestMethod]
        public void Add_AdminirSaltosDeLineaEnLugarDeComas_DebeDevolverLaSumaDeTodosLosNumeros()
        {
            //Arrange
            string numeros = "1 \n2,3";
            int expected = 6;

            //Act
            int resultado = numeros.Add();

            //Assert
            Assert.AreEqual(expected, resultado);

        }

        //Parte V
        //Si Add recibe un número negativo arrojará una excepción NegativoNoPermitidoException
        //que en su mensaje contendrá el negativo que se recibió.

        [TestMethod]
        [ExpectedException(typeof(NegativoNoPermitidoException))]
        public void Add_SiRecibeUnNumeroNegativo_LanzaException()
        {
            //Arrange
            string numeros = "-2";
            //int expected = 6;

            //Act
            int resultado = numeros.Add();

        }


    }
}
