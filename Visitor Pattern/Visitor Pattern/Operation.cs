using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public interface Operation
    {
        void Apply(HeadingNode headingNode);
        void Apply(AnchorNode anchorNode);
    }
}
