using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility
{
    public class HttpRequest
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public HttpRequest(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
