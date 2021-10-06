using System;
using System.Collections.Generic;
using System.Text;

namespace Iretator_Pattern
{
    public class ListIterator : Iterator
    {
        private readonly BrowseHistory _history;
        private int index;
        public ListIterator(BrowseHistory history)
        {
            _history = history;
        }
        public string current()
        {
            return _history.GetHistory(index);
        }

        public bool hasNext()
        {
            return true;
        }

        public void next()
        {
            index++;
        }
    }
}
