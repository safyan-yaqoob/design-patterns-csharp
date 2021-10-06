using System;

namespace Adaptor_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var imageView = new ImageView();
            imageView.Apply(new CaramelFilter(new Caramel()));
        }
    }
}
