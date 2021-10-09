using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight_Pattern
{
    public class Point
    {
        private int X;
        private int Y;
        private PointIcon PointIcon;
        
        public Point(int x,int y,PointIcon pointIcon)
        {
            X = x;
            Y = x;
            PointIcon = pointIcon;
        }

        public void Draw()
        {
            Console.WriteLine($"{PointIcon.GetType()} at {X},{Y}");
        }
    }
}
