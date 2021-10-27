using System;

namespace Proxy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var library = new Library();
            string[] fileNames = new string[] { "a", "b", "c" };
            foreach (var item in fileNames)
            {
                library.Add(new EbookProxy(item));
            }

            library.OpenEbook("a");
        }
    }
}
