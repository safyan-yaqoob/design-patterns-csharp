using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class NotificationService
    {
        public void Send(string msg, string target)
        {
            var server = new NotificationServer();
            var connection = server.Connect("ip");
            var authToken = server.Autheticate("appId","key");
            server.Send(authToken, new Message(msg), target);
            connection.DisConnect();
        }
    }
}
