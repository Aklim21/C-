using System;
using Xunit;
using PrimeFactorsLib;

namespace PrimeFactorsLibUnitTests
{
    public class IsPrimeTest
    {
        [Fact]
        public void Test1()
        {
            //arrange: 
            double a = 2;
            double b = 2;
            double expected = 4;
            var calc = new Calculator();

            //act:
            double actual = calc.Add(a,b);

            //assert: 
            Assert.Equal(expected, actual); 
        }

        [Fact]
        public void Test2()
        {

        }   
        
        [Fact]
        public void Test3()
        {

        }      
    }
}
