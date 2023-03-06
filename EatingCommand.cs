using System;

namespace Test1
{
    class EatingCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("This is the eating command.");
        }
    }
}