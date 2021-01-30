using System;
using static System.Console;
using PrimeFactorsLib;

namespace PrimeFactors
{
    class Program
    {
        static void Main(string[] args)
        {
            var getPrime = new PrimeFunctions();

            bool isNumber = false;
            while(isNumber == false)
            {
                WriteLine("Enter a positive value up to 1000:");
                isNumber = int.TryParse(ReadLine(),out int number);
                if(isNumber == true && number>0 && number<=1000)
                {
                    WriteLine(getPrime.getPrimeFact(number));
                }
                else
                {
                    WriteLine("You fucked it, try again.");
                    isNumber = false;
                }
            }
        }
    }
}
