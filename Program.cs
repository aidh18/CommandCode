using System;
using System.Collections.Generic;

namespace Test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Command> commands = new Dictionary<string, Command>();
            commands["1"] = new BreathingCommand();
            commands["2"] = new ReflectingCommand();
            commands["3"] = new ListingCommand();
            commands["4"] = new EatingCommand();

            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Which command would you like to run? ");
                string choice = Console.ReadLine();

                commands[choice].Execute();
            }

        }
    }
}