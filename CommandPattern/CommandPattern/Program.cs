using System;

namespace CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command Pattern");
            Console.WriteLine("================");
            //TurnLightOn tlo = new TurnLightOn();
            //tlo.Execute();

            Invoker invoker = new Invoker();
            invoker.SetOnStart(new TurnLightOn());
            Receiver receiver = new Receiver();
            invoker.SetOnFinish(new TurnLightOff());

            invoker.DoSomethingImportant();
        }
    }
}
