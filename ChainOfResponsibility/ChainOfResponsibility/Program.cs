using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var compressor = new Compressor(null);
            var logger = new Logging(compressor);
            var authenticator = new Authenticator(logger);
            var server = new WebServer(authenticator);
            server.Handle(new HttpRequest("", "1234"));
        }
    }
}
