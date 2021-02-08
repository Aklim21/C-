using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public class Person : object
    {
        //fields
        public string szLastName;
        public string szFirstName;
        public DateTime dtDateofBirth;
        public WondersOfTheWorld FavouriteAncientWonder;
        public WondersOfTheWorld BucketList;
        public List<Person> Children = new List<Person>();
        //const
        public const string szSpecies = "Homo sapien";
        //read-only
        public readonly string szHomePlanet = "Earth";
        public readonly DateTime dtCreatedDate;


        //constructors
        //set default values for instances we generate
        public Person()
        {
            szFirstName = "Unknown";
            dtCreatedDate = DateTime.Now;
        }

        public Person( string FirstName, string LastName, string HomePlanet)
        {
            szFirstName = FirstName;
            szLastName = LastName;
            szHomePlanet = HomePlanet;
            dtCreatedDate = DateTime.Now;
        }

        /*------------------------------------*/
        //methods:
        public void Print()
        {
            WriteLine($"{szFirstName} was born on a {dtDateofBirth:dddd}");

        }
        public string GetOrigin()
        {
            return ($"{szFirstName} was born on {szHomePlanet}");
        }

    }
}
