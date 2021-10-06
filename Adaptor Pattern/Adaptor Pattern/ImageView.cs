using System;
using System.Collections.Generic;
using System.Text;

namespace Adaptor_Pattern
{
    public class ImageView
    {
        public ImageView()
        {
            Image = new Image();
        }
        public Image Image { get; set; }

        public void Apply(Filter filter)
        {
            filter.Apply(Image);
        }
    }
}
