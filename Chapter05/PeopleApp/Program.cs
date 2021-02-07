using System;
using static System.Console;
using Packt.Shared;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longhand instantiation
            var ant = new Person();
            ant.LastName = "Jim";
            ant.FirstName = "Anthony";
            ant.DateofBirth = new DateTime(1996,06,17);

            // WriteLine(
            //     format: "{0} {1} was born on {2:dddd, d MMMM yyyy}",
            //     arg0: ant.FirstName,
            //     arg1: ant.LastName,
            //     arg2: ant.DateofBirth);


            //Shorthand intitalisation:
            var jen = new Person()
            {
                //shorthand instantiation
                FirstName = "Jennifer",
                LastName = "Jim",
                DateofBirth = new DateTime(1954,12,27),
                FavouriteAncientWonder = WondersOfTheWorld.TempleOfArtemisAtEphesus,
                BucketList = WondersOfTheWorld.StatueofZeusAtOlympia | WondersOfTheWorld.ColossusOfRhodes  
            };
            // WriteLine
            // (
            //     $"{jen.FirstName}'s bucket list of wonders to visit is {jen.BucketList}"
            // );
            // //Adding collections
            jen.Children.Add(new Person 
                {
                    FirstName = "Shit_one",
                    LastName = jen.LastName
                }
            );
            jen.Children.Add(new Person 
                {
                    FirstName = "Shit_two",
                    LastName = jen.LastName
                }
            );
            //Foreach loop on collections & enumerables
            // WriteLine($"{jen.FirstName} has {jen.Children.Count} children:");
            // foreach(Person child in jen.Children)
            //     {
            //         WriteLine($"{child.FirstName}");
            //     }
            // var wonders = Enum.GetValues(typeof(WondersOfTheWorld));
            // foreach(var i in wonders)
            // {
            //     WriteLine(i);
            // }
        }
    }

}
