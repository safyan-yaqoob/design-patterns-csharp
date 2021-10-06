using System;

namespace Iretator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var history = new BrowseHistory();
            Iterator<string> iterator = history.CreateIterator();
            while (iterator.hasNext())
            {
                var url = iterator.current();
                Console.WriteLine(url);
                iterator.next();
            }
        }
    }
}
