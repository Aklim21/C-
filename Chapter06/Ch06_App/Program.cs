using System;
using Ch06_Library;
using static System.Console;

namespace Ch06_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Person ant = new Person()
            {
                szName = "Anthony",
                dtDateofBirth = new DateTime(1996, 06, 17)

            };
            
            //new Person instances
            Person dave = new Person{szName = "David"};
            Person gol = new Person{szName = "Goliath"};
            Person mossy = new Person{szName = "Moses"};

            //Call static Method:
            var daliath = Person.Woohoo(dave,gol);

            // WriteLine(
            //     $"{dave.szName} has {dave.Children.Count} child(ren).\n{gol.szName} has {gol.Children.Count} child(ren)."
            // );

            // WriteLine($"{dave.szName} and {gol.szName} have a child called: \"{daliath.szName}\".");

            //Operator function
            // var gavid = dave *gol;
            // WriteLine(
            //     $"{dave.szName} has {dave.Children.Count} child(ren).\n{gol.szName} has {gol.Children.Count} child(ren)."
            // );
            // gavid.szName = "Gavid";
            // WriteLine($"{dave.szName} and {gol.szName} have a child called: \"{gavid.szName}\".");

            /*----------------------------------*/
            //Local functions

            var x = 4;
            var y = math.Factorial(x);
            // WriteLine($"The factorial of {x} is {y}");
            
            /*----------------------------------*/
            //Delegates

            int testString = math.CalledMethod("Welcome");
            // WriteLine(testString);

            var d = new math.DelegateMethodCall(math.CalledMethod);
            var testString2 = d("Welcome");
            // WriteLine(testString2);


            /*----------------------------------*/
            //Set Events and delegates
            ant.Shout = ant_Shout;
            ant.Poke();
            ant.Poke();
            ant.Poke();
            ant.Poke();

        }
        public static void ant_Shout(object sender, EventArgs e)
        {
            Person p = (Person)sender;
            WriteLine($"{p.szName} is level {p.AngerLevel} angry!");
        }
        
    }
}
