using System;
using static System.Console;
using Packt.Shared;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var bob = new Person();
            WriteLine(bob.ToString());
        }
    }
}
