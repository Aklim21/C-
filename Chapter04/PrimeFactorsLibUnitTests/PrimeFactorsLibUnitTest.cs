using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class IsPrimeTest
    {
        [Fact]
        public void testPrime1()
        {
            //arrange: 
            int i = 5;
            bool expected = true;
            var checkPrime = new PrimeFunctions();

            //act:
            bool actual = checkPrime.isPrime(i);

            //assert: 
            Assert.Equal(expected, actual); 
        }   
        
        [Fact]
        public void testPrime2()
        {
            //arrange: 
            int i = 10;
            bool expected = false;
            var checkPrime = new PrimeFunctions();

            //act:
            bool actual = checkPrime.isPrime(i);

            //assert: 
            Assert.Equal(expected, actual); 
        }  

        [Fact]
        public void getPrime1()
        {
            //arrange: 
            int i = 10;
            string expected = ("5x2");
            var getPrime = new PrimeFunctions();

            //act:
            string actual = getPrime.getPrimeFact(i);

            //assert: 
            Assert.Equal(expected, actual); 
        }  
        [Fact]
        public void getPrime2()
        {
            //arrange: 
            int i = 100;
            string expected = ("5x5x2x2");
            var getPrime = new PrimeFunctions();

            //act:
            string actual = getPrime.getPrimeFact(i);

            //assert: 
            Assert.Equal(expected, actual); 
        }  
    }
}
