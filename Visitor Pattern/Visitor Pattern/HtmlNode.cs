using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public interface HtmlNode
    {
        void Execute(Operation operation);
    }
}
