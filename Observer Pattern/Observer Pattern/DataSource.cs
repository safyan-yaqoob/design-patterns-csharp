using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class DataSource : Subject
    {
        private int Value;
        public int value
        {
            get { return Value; }
            set
            {
                Value = this.value;
                this.NotifyObservers(Value);
            }
        }
    }
}
