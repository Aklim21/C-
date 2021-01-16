using System;

namespace HelloCS
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new [] {12.56,11.56,10.56};
            double total = 0;
            for (int i=0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            Console.WriteLine(total);
        }
    }
}