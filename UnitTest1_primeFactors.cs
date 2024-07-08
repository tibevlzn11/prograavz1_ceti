using System;
using Xunit;
using PrimeFactors;
namespace PrimeFactorsUnitTest
{
    public class UnitTest1
    {
        [Fact]
        public void numerosNegativos()//Prueba el funcionamiento con numeros Negativos
        {
            //arrange
            int numeroIng=-785;
            string factoresEsp="|5|157(-1)";
            var facts =new Functions();
            //act
            string actual = facts.SacarFactores(numeroIng);
            //assert
            Assert.Equal(factoresEsp, actual);
        }
        [Fact]
        public void ExcederMax()//Prueba si la funcion descompone numeros mayores a 1000
        {
            //arrange
            int numeroIng=1056;
            string factoresEsp="|2|2|2|2|2|3|11";
            var facts =new Functions();
            //act
            string actual = facts.SacarFactores(numeroIng);
            //assert
            Assert.Equal(factoresEsp, actual);
        }
    }
}
