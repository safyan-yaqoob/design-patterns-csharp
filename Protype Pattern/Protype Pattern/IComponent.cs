using System;
using System.Collections.Generic;
using System.Text;

namespace Protype_Pattern
{
    public interface IComponent
    {
        void Render();
        IComponent Clone();
    }
}
