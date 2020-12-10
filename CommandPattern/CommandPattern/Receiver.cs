using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class Receiver
    {
        public void Action(ICommand command)
        {
            Console.WriteLine("Action of: " + command.GetType());
        }
    }
}
