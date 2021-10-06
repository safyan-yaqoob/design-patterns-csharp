using System;

namespace State_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var canvas = new Canvas();
            canvas.currentTool = new BrushTool();
            canvas.MouseDown();
            canvas.MouseUp();
        }
    }
}
