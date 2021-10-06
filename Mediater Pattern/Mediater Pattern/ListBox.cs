using System;
using System.Collections.Generic;
using System.Text;

namespace Mediater_Pattern
{
    public class ListBox : UIControl
    {
        private int Selection { get; set; }
        public int selection
        {
            get { return this.Selection; }
            set
            {
                this.Selection = value;
                this.NotifyObservers();
            }
        }
    }
}
