using System;
using System.Collections.Generic;
using System.Text;

namespace Iretator_Pattern
{
    public interface Iterator
    {
        bool hasNext();
        string current();
        void next();
    }
}
