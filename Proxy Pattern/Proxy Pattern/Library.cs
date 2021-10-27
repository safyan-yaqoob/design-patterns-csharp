using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class Library
    {
        private Dictionary<string, EbookProxy> eBooks = new Dictionary<string, EbookProxy>();
        public void Add(EbookProxy book)
        {
            eBooks.Add(book.GetFileName(), book);
        }

        public void OpenEbook(string fileName)
        {
            eBooks[fileName].Show();
        }
    }
}
