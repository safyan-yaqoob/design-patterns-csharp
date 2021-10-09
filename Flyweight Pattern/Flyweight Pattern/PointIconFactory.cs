using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointIconFactory
    {
        private Dictionary<PointType, PointIcon> PointIcons = new Dictionary<PointType, PointIcon>();
        public PointIcon GetPointIcon(PointType type)
        {
            if (!PointIcons.ContainsKey(type))
            {
                var icon = new PointIcon(type, null);
                PointIcons.Add(type, icon);
            }

            return PointIcons[type];
        }
    }
}
