using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class BrushTool : Tool
    {
        public void MouseDown()
        {
            Console.WriteLine("Brush Icon");
        }

        public void MouseUp()
        {
            Console.WriteLine("Draw a line");
        }
    }
}
