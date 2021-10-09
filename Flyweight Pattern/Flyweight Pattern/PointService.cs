using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class PointService
    {
        private PointIconFactory PointIconFactory;
        public PointService(PointIconFactory pointIconFactory)
        {
            PointIconFactory = pointIconFactory;
        }
        public List<Point> GetPoints()
        {
            List<Point> points = new List<Point>();
            var point = new Point(1, 2, PointIconFactory.GetPointIcon(PointType.CAFE));
            points.Add(point);

            return points;
        }
    }
}
