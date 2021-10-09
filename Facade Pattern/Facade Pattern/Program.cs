using System;

namespace Facade_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var notificationService = new NotificationService();
            notificationService.Send("message","taget");
        }
    }
}
