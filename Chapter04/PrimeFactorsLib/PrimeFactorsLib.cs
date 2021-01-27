using System;
using static System.Console;

namespace PrimeFactorsLib
{
    public class PrimeFunctions
    {
        public static bool isPrime(int number)
        {
    
            if (number <= 1) return false;
            if (number == 2 || number == 3 || number == 5) return true;
            if (number % 2 == 0 || number % 3 == 0 || number % 5 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for(int i=6 ; i <= boundary ; i+=6)
            {
                if (number % (i + 1) == 0 || number % (i + 5) == 0)
                {
                    return false;
                }
            }
            return true;    
        }

        public static string getPrimeFact(int number)
        {

            string facts = new string [];
                for(int i = (number-1) ; i <1 ; i--)
                {
                    if (isPrime(i))
                    {
                        if(number % i ==0)
                        {
                            number /= i;
                            facts.Add(i);
                            i++;
                        }
                    }
                }
            
        }
    }
}
