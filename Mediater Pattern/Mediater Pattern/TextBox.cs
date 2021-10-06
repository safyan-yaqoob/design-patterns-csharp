using System;
using System.Collections.Generic;
using System.Text;

namespace Mediater_Pattern
{
    public class TextBox : UIControl
    {
        private int Content;

        public int content
        {
            get { return Content; }
            set
            {
                Content = value;
                this.NotifyObservers();
            }
        }

    }
}
