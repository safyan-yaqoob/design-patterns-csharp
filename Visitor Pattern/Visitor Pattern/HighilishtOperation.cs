using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HighilishtOperation : Operation
    {
        public void Apply(HeadingNode headingNode)
        {
            Console.WriteLine("Highlight Heading");
        }

        public void Apply(AnchorNode anchorNode)
        {
            Console.WriteLine("Highlight Anchor");
        }
    }
}
