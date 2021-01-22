using System;
using static System.Console;
using System.Collections.Generic;

namespace Code
{
    class Program
    {
        static void Main(string[] args)
        {

              WriteLine("Enter Number 1");
              string one = Console.ReadLine();
              WriteLine("Enter Number 2");
              string two = Console.ReadLine();

              try {
                double num_one = double.Parse(one);
                double num_two = double.Parse(two);
                if (num_one >0 && num_one <255 && num_two >0 && num_two <255){
                  WriteLine(num_one / num_two);
                }
                else {
                  WriteLine("Values outside valid range.");
                }
              }
              catch (FormatException) { 
                      WriteLine("The number you entered is not a valid number format."); 
                    }
              catch (Exception ex) {    
                      WriteLine($"{ex.GetType()} says {ex.Message}");        
                    }

              }
        }
    }


