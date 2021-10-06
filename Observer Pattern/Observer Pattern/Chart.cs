using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Chart : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("Chat got update",value);
        }
    }
}
