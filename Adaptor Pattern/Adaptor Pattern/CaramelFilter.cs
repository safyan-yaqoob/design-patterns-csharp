using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor_Pattern
{
    public class CaramelFilter : Filter
    {
        public CaramelFilter(Caramel caramel)
        {
            Caramel = caramel;
        }
        private Caramel Caramel { get; set; }
        public void Apply(Image image)
        {
            Caramel.Init();
            Caramel.Render(image);
        }
    }
}
