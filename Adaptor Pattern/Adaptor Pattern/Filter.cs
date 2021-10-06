using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor_Pattern
{
    public interface Filter
    {
        void Apply(Image image);
    }
}
