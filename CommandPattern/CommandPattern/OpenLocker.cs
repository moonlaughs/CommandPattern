using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class OpenLocker : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("Locker opening...");
        }
    }
}
