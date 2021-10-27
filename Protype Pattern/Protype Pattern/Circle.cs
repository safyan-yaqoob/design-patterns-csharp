using System;
using System.Collections.Generic;
using System.Text;

namespace Protype_Pattern
{
    public class Circle : IComponent
    {
        public int Radius { get; set; }
        public IComponent Clone()
        {
            Circle target = new Circle();
            target.Radius = this.Radius;
            return target;
        }

        public void Render()
        {
            Console.WriteLine("Rendering a circle");
        }
    }
}
