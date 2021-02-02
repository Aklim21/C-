using System;
using static System.Console;
using Packt.Shared;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var ant = new Person();
            ant.LastName = "Jim";
            ant.FirstName = "Anthony";
            ant.DateofBirth = new DateTime(1996,06,17);

            WriteLine(
                format: "{0} {1} was born on {2:dddd, d MMMM yyyy}",
                arg0: ant.FirstName,
                arg1: ant.LastName,
                arg2: ant.DateofBirth);


            //Shorthand intitalisation:
            var jen = new Person()
            {
                FirstName = "Jennifer",
                LastName = "Jim",
                DateofBirth = new DateTime(1954,12,27)
            };
            WriteLine(
                format: "{0} {1} was born on {2:dd MMM yy}",
                arg0: jen.FirstName,
                arg1: jen.LastName,
                arg2: jen.DateofBirth
            );
        }
    }
}
