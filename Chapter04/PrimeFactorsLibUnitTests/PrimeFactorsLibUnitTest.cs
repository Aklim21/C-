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
            var checkPrime = new isPrime();

            //act:
            bool actual = CheckPrime.Add(i);

            //assert: 
            Assert.Equal(expected, actual); 
        }    
    }
}
