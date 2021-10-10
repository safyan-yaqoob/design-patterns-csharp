using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge_Pattern
{
    public class SamsungTV : Device
    {
        public void SetChannel(int number)
        {
            Console.WriteLine("Set Channel");
        }

        public void TurnOff()
        {
            Console.WriteLine("Samsung turn off");
        }

        public void TurnOn()
        {
            Console.WriteLine("Samsung turn on");
        }
    }
}
