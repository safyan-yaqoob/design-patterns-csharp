using System;

namespace Strategy_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageStorage = new ImageStorage(new JpegCompressor(),new BlackAndWhiteFilter());
            imageStorage.Store("a");
        }
    }
}
