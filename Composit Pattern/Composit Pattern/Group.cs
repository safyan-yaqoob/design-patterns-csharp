using System;
using System.Collections.Generic;
using System.Text;

namespace Composit_Pattern
{
    public class Group:IComponent
    {
        public Group()
        {
            Components = new List<IComponent>();
        }
        public List<IComponent> Components { get; set; }
        public void Add(IComponent component)
        {
            Components.Add(component);
        }

        public void Render()
        {
            foreach (var item in Components)
            {
                item.Render();
            }
        }
    }
}
