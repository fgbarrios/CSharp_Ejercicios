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

        //Permitir que el m�todo Add maneje una cantidad desconocida de n�meros.
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
        //Permita que el m�todo Add admita salto de l�nea entre n�meros(en lugar de comas).
        //La siguiente entrada est� bien: "1 \ n2,3" (ser� igual a 6).
        //La siguiente entrada NO est� bien: "1, \ n" (no es necesario probarlo, solo se aclara)
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
        //Si Add recibe un n�mero negativo arrojar� una excepci�n NegativoNoPermitidoException
        //que en su mensaje contendr� el negativo que se recibi�.

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
