using System;
using System.Collections.Generic;
using System.Text;

namespace CommandPattern
{
    public class CloseLocker : ICommand
    {
        public void Execute()
        {
            Console.WriteLine("closing locker...");
        }
    }
}
