using System;

namespace Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            StoreCreditCard(new CompressedCloudStream(new CloudStream()));
        }


        static void StoreCreditCard(Stream stream)
        {
            stream.Write("1234-1234-1234-1234");
        }
    }
}
