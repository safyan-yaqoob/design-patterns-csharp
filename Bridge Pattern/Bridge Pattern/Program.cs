using System;

namespace Bridge_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var remoteControl = new AdvanceRemoteControl(new SoneyTV());
            remoteControl.TurnOn();
        }
    }
}
