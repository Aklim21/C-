using System;
using System.Collections.Generic;
using static System.Console;

namespace Packt.Shared
{
    public partial class Person : object
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

        /*------------------------------------*/
        //Tuples
        public (string, int) GetFruit(int x)
        {
            return ("Banana", x);
        }
        public static (string lensType, int quant) GetLenses()
        {
            return ("Prime", 3);
        }
        /*------------------------------------*/
        //method overload
        public string SayHello() 
        { 
            return $"{szFirstName} says 'Hello!'"; 
        }
        public string SayHello(string name) 
        { 
            return $"{szFirstName} says 'Hello {name}!'";
        }
        public string SayHello(int x) 
        { 
            return $"{szFirstName} said 'Hello!' {x} times already!!!";
        }

        /*------------------------------------*/
        //optional parameters

        public string OptionalParam
        (
            string command = "Run!",
            double number = 0.234,
            bool active = false
        )
        {
            return string.Format
            (
                format: "I told you to {0} This should have been done {1} seconds ago!. Has it been done? {2}.",
                arg0: command,
                arg1: number,
                arg2: active
            );
        }

        /*------------------------------------*/
        //Param control

        public static void ParamControl (int x, ref int y, out int z)
        {
            z = y+x; //out params cannot have a default. Must assign value.

            //Increment vals
            x++;
            y++;
            z++;
        }

        public static void outParam (out int z)
        {
            z = 100;
        }

        /*------------------------------------*/
        //Indexer access

        public Person this[int index]
        {
            get
            {
                return Children[index];
            }
            set
            {
                Children[index] = value;
            }
        }












    }
}
