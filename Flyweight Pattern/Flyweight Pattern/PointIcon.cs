using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIcon
    {
        private PointType Type;
        private byte[] Icon;
        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }

        public PointType GetType()
        {
            return Type;
        }
    }
}
