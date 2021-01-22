using System;
using static System.Console;

namespace Arguments
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
            if (args.Length < 4){
                WriteLine("Please input two colours and dimensions");
                WriteLine("e.g.: dotnet run red yellow 80 40");
                return;
=======
            WriteLine($"There are {args.Length} arguments");
            foreach(string arg in args){
                WriteLine(arg);
>>>>>>> a58c581d0cb028a457bb884b4840589187fc21c8
            }
            ForegroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[0],
                ignoreCase: true);

            BackgroundColor = (ConsoleColor)Enum.Parse(
                enumType: typeof(ConsoleColor),
                value: args[1],
                ignoreCase: true);

            WindowWidth = int.Parse(args[2]);
            WindowHeight = int.Parse(args[3]);
        }
    }
}

