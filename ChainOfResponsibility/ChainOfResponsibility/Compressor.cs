using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Compressor:Handler
    {
        public Compressor(Handler handler):base(handler)
        { }

        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Compress");
            return false;
        }
    }
}
