using System;
using System.Collections.Generic;
using System.Text;

namespace State_Pattern
{
    public class Canvas
    {
        public Tool currentTool { get; set; }
        public void MouseDown()
        {
            currentTool.MouseDown();
        }
        public void MouseUp()
        {
            currentTool.MouseUp();
        }

    }
}
