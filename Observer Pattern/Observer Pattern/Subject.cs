using System;
using System.Collections.Generic;
using System.Text;

namespace Observer_Pattern
{
    public class Subject
    {
        private List<IObserver> observers = new List<IObserver>();
        public void AddObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void NotifyObservers(int value)
        {
            foreach (var item in observers)
            {
                item.Update(value);
            }
        }
    }
}
