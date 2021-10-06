using System;
using System.Collections.Generic;
using System.Text;

namespace Iretator_Pattern
{
    public interface AbstractCollection
    {
        ListIterator CreateIterator();
    }
}
