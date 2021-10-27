using System;
using System.Collections.Generic;
using System.Text;

namespace Protype_Pattern
{
    public class ContextMenu
    {
        public void Duplicate(IComponent component)
        {
            IComponent newComponent = component.Clone();
        }
    }
}
