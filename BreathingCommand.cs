using System;
using System.Collections.Generic;

namespace Test1
{
    class BreathingCommand : Command
    {
        private List<Command> _commands = new List<Command>();
        public BreathingCommand()
        {
            // _commands.Add(new BreathingCommand()); Infinite recursion is fun
            _commands.Add(new ReflectingCommand());
            _commands.Add(new ListingCommand());
            _commands.Add(new EatingCommand());
        }
        public override void Execute()
        {
            Console.WriteLine("This is the breathing command.");
            foreach (Command command in _commands)
            {
                command.Execute();
            }
        }
    }
}