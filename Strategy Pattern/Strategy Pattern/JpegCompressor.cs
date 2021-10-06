using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class JpegCompressor : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compressing using JPEG");
        }
    }
}
