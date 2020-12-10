using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnLightOff : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Turning lights off...");
        }
    }
}
