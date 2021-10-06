using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class Authenticator:Handler
    {
        public Authenticator(Handler handler):base(handler)
        {}
        public override bool DoHandle(HttpRequest request)
        {
            var isValid = (request.Username == "Admin" && request.Password == "1234") ? true : false;
            Console.WriteLine(isValid);
            return !isValid;
        }
    }
}
