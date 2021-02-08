using System;
using Packt.Shared;
using static System.Console;


namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Longhand instantiation
            var ant = new Person();
            ant.szLastName = "Jim";
            ant.szFirstName = "Anthony";
            ant.dtDateofBirth = new DateTime(1996,06,17);

            // WriteLine(
            //     format: "{0} {1} was born on {2:dddd, d MMMM yyyy}",
            //     arg0: ant.szFirstName,
            //     arg1: ant.szLastName,
            //     arg2: ant.dtDateofBirth);


            //Shorthand intitalisation:
            var jen = new Person()
            {
                //shorthand instantiation
                szFirstName = "Jennifer",
                szLastName = "Jim",
                dtDateofBirth = new DateTime(1954,12,27),
                FavouriteAncientWonder = WondersOfTheWorld.TempleOfArtemisAtEphesus,
                BucketList = WondersOfTheWorld.StatueofZeusAtOlympia | WondersOfTheWorld.ColossusOfRhodes  
            };
            // WriteLine
            // (
            //     $"{jen.szFirstName}'s bucket list of wonders to visit is {jen.BucketList}"
            // );
            //------------------------------------------------------------------------------
            // //Adding collections
            jen.Children.Add(new Person 
                {
                    szFirstName = "Shit_one",
                    szLastName = jen.szLastName
                }
            );
            jen.Children.Add(new Person 
                {
                    szFirstName = "Shit_two",
                    szLastName = jen.szLastName
                }
            );
            //Foreach loop on collections & enumerables
            // WriteLine($"{jen.szFirstName} has {jen.Children.Count} children:");
            // foreach(Person child in jen.Children)
            //     {
            //         WriteLine($"{child.szFirstName}");
            //     }
            // var wonders = Enum.GetValues(typeof(WondersOfTheWorld));
            // foreach(var i in wonders)
            // {
            //     WriteLine(i);
            // }

            //------------------------------------------------------------------------------
            // Setting static fields

            //fields
            BankAccount.InterestRate = 0.012M; //Stores a shared value


            var antsAccount = new BankAccount();
            antsAccount.AccountName = "Mr. Kcoon Leung Jim";
            antsAccount.Balance = 2300;

            // WriteLine(
            //     format: "{0} earned {1:c} in interest",
            //     arg0: antsAccount.AccountName,
            //     arg1: antsAccount.Balance * BankAccount.InterestRate
            // );
            //const values are drawn from the class type
            //WriteLine($"{ant.szFirstName} is a {Person.szSpecies}");

            //readonly values are drawn from the object instance as this is inherited
            //WriteLine($"{ant.szFirstName}'s home planet is {ant.szHomePlanet}");

            //Generate new person and identify default values: 
            var newCharacter = new Person();
            //WriteLine($"newCharacter: {newCharacter.szFirstName} was created at {newCharacter.dtCreatedDate:hh:mm:ss} on {newCharacter.dtCreatedDate:dd:MMMM:yyyy}");
       
            var Waggas = new Person("Waggas","Jerob","Pluto");
            // WriteLine(
            //     format: "{0} {1} is an alien from {2}",
            //     arg0: Waggas.szFirstName,
            //     arg1: Waggas.szLastName,
            //     arg2: Waggas.szHomePlanet
            // );

            // Console.WriteLine($"default(int) = {default(int)}");
            // Console.WriteLine($"default(bool) = {default(bool)}");
            // Console.WriteLine($"default(DateTime) = {default(DateTime)}");
            // Console.WriteLine($"default(string) = {default(string)}");
       

            var defaultThing = new Defaults();
            // WriteLine(
            //     $"{defaultThing.Population}\n{defaultThing.When}\n{defaultThing.Name}\n{defaultThing.People}"
            // );

            ant.Print();
            WriteLine(ant.GetOrigin());

        }
    }

}
