using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor_Pattern
{
    public class VividFilter : Filter
    {
        public void Apply(Image image)
        {
            Console.WriteLine("Applying vivid filte...r");
        }
    }
}
