using System;

namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new PointService(new PointIconFactory());
            foreach (var item in service.GetPoints())
            {
                item.Draw();
            }

        }
    }
}
