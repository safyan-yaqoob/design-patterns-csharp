using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor_Pattern
{
    public class HtmlDocument
    {
        private List<HtmlNode> nodes = new List<HtmlNode>();

        public void Add(HtmlNode node)
        {
            this.nodes.Add(node);
        }

        public void Execute(Operation operation)
        {
            foreach (var item in nodes)
            {
                item.Execute(operation);
            }
        }
    }
}
