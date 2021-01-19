using System;
using static System.Console;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {
 A_label:
         string number = "Six";
         WriteLine($"My random number is {number}");

      switch (number)
     {
       case "one":
         WriteLine("One");
         break; // jumps to end of switch statement
       case "two":
         WriteLine("Two");
         goto case "two";
       case "three":
       case "four":
         WriteLine("Three or four");
         goto case "one";
       case "six":
         // go to sleep for half a second
         System.Threading.Thread.Sleep(500);
         goto A_label;
       default:
         WriteLine("Default");
         break;
     } // end of switch statement

        }
    }
}
