using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SoneyTV : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Soney Turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Soney Turn on");
        }
    }
}
