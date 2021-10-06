using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class BlackAndWhiteFilter : IFilter
    {
        public void Apply(string fileName)
        {
            Console.WriteLine("Applt black and white filter.");
        }
    }
}
