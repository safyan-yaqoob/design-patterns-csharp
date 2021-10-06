using System;
using System.Collections.Generic;
using System.Text;

namespace Composit_Pattern
{
    public class Shape : IComponent
    {
        public void Render()
        {
            Console.WriteLine("Rendering a shape");
        }
    }
}
