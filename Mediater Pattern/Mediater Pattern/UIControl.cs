using System;
using System.Collections.Generic;
using System.Text;

namespace Mediater_Pattern
{
    public class UIControl
    {
        private List<IObserver> observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            observers.Add(observer);
        }

        protected void NotifyObservers()
        {
            foreach (var item in observers)
            {
                item.Update();
            }
        }
    }
}
