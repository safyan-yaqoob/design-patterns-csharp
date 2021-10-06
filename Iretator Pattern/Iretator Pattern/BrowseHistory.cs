using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iretator_Pattern
{
    public class BrowseHistory:AbstractCollection
    {
        private List<string> urls = new List<string>();

        public ListIterator CreateIterator()
        {
            return new ListIterator(this);
        }

        public string GetHistory(int index)
        {
            return urls.ElementAt(index);
        }
    }
}
