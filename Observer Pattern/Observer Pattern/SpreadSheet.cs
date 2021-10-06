using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class SpreadSheet : IObserver
    {
        public void Update(int value)
        {
            Console.WriteLine("SpreadSheet got updated",value);
        }
    }
}
