using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class CloudStream : Stream
    {
        public void Write(string data)
        {
            Console.WriteLine("Storing" + data);
        }
    }
}
