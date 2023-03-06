using System;

namespace Test1
{
    class ListingCommand : Command
    {
        public override void Execute()
        {
            Console.WriteLine("This is the listing command.");
        }
    }
}