using System;
using System.Collections.Generic;
using static System.Console;


namespace Ch06_Library
{
    public class Person
    {
        //Fields
        public string szName;
        public DateTime dtDateofBirth;
        public List<Person> Children = new List<Person>();

        //static Method

        public static Person Woohoo(Person x, Person y)
        {
            var baby = new Person
            {
                szName = $"Baby of {x.szName} and {y.szName}"
            };

            x.Children.Add(baby);
            y.Children.Add(baby);

            return baby;
        }

        //instance Method

        public Person WoohooWith(Person spouse)
        {
            return Woohoo(this, spouse);
        }

        public static Person operator * (Person x, Person y)
        {
            return Person.Woohoo(x,y);
        }


        /*----------------------------------*/
        //Delegates and events: 
        
        //define the delegate field for each person
        public EventHandler Shout;

        //define the AngerLevel field for each person
        public int AngerLevel;
        //define the method to be called on event activation
        public void Poke()
        {
            AngerLevel++;
            if (AngerLevel >= 3)
            {
                //if something is listening...

                // if (Shout != null)
                // {
                //     Shout(this, EventArgs.Empty);
                // }
                Shout?.Invoke(this, EventArgs.Empty);

            }
        }
    


    }










    /*----------------------------------*/
    //Local functions
    public class math
    {
        public static int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentException($"Number has to be larger that 0!");
            }
            return LocalFactorial(number);

            int LocalFactorial(int localNumber)
            {
                if (localNumber < 1) return 1;
                return localNumber * LocalFactorial(localNumber - 1);
            }
        }

        /*----------------------------------*/
        //Delegates

        public static int CalledMethod(string input)
        {
            return input.Length;
        }
        public delegate int DelegateMethodCall(string s);




    
        









    }
}
