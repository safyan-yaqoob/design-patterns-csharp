using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NotificationServer
    {
        public Connection Connect(string IP)
        {
            return new Connection();
        }

        public AuthToken Autheticate(string appID,string key)
        {
            return new AuthToken();
        }

        public void Send(AuthToken authToken,Message msg, string target)
        {
            Console.WriteLine("Sending a message");
        }
    }
}
