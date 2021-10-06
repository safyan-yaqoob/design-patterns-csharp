using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Logging:Handler
    {
        public Logging(Handler handler):base(handler)
        {

        }
        public override bool DoHandle(HttpRequest request)
        {
            Console.WriteLine("Log");
            return false;
        } 
    }
}
