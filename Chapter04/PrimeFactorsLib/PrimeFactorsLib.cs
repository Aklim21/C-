using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace PrimeFactorsLib
{
    public class PrimeFunctions
    {
        public bool isPrime(int number)
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

        public List<string> getPrimeFact(int number)
        {
            List<string> facts = new List<string>();
            int x = number;
            for(int i = (number-1) ; i > 2 ; i--)
            {
                if (isPrime(i))
                {
                    while(x % i ==0)
                    {
                        x /= i;
                        facts.Add(i.ToString());
                    }
                }
                else
                {
                    continue;
                }
            }
            return facts;
            
        }
    }
}
