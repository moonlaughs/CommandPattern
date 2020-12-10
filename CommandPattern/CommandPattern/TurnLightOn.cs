using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class TurnLightOn : ICommand
    {
        Receiver receiver = new Receiver();
        public void Execute()
        {
            Console.WriteLine("Turning light on...");
            receiver.Action(this);
        }
    }
}
