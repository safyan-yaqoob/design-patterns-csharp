using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public interface IFilter
    {
        void Apply(string fileName);
    }
}
