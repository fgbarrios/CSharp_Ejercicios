using Microsoft.VisualStudio.TestTools.UnitTesting;
using Biblioteca;

namespace Test_FizzBuzz
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorTres_DeberiaRetornarFizz()
        {
            //Arrange
            int[] prueba = { 3 };
            string expected = "fizz";

            //Act
            // aca se llama el metodo a probar
            string actual = prueba.FizzBuzz();

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            //Assert.AreEqual(expected, actual);
            StringAssert.Equals(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorCinco_DeberiaRetornarBuzz()
        {
            //Arrange
            int[] prueba = { 5 };
            string expected = "buzz";

            //Act
            // aca se llama el metodo a probar
            string actual = prueba.FizzBuzz();

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            //Assert.AreEqual(expected, actual);
            StringAssert.Equals(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroEsDivisiblePorTresYCinco_DeberiaRetornarFizzBuzz()
        {
            //Arrange
            int[] prueba = { 15 };
            string expected = "fizz buzz";

            //Act
            // aca se llama el metodo a probar
            string actual = prueba.FizzBuzz();

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            //Assert.AreEqual(expected, actual);
            StringAssert.Equals(expected, actual);

        }

        [TestMethod]
        public void FizzBuzz_CuandoElNumeroNOEsDivisiblePorTresYCinco_NoDeberiaRetornarPalabras()
        {
            //Arrange
            int[] prueba = { 2 };
            string expected = "2";

            //Act
            // aca se llama el metodo a probar
            string actual = prueba.FizzBuzz();

            //Assert
            //Assert.Equals(expected, actual); //Equals evalua si son el mismo objeto y tienen la misma direccion de memoria
            //Assert.AreEqual(expected, actual);
            StringAssert.Equals(expected, actual);
        }

    }
}
