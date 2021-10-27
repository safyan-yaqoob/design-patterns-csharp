using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class EbookProxy : EBook
    {
        private string FileName;
        private RealEbook ebook;
        public EbookProxy(string fileName)
        {
            FileName = fileName;
        }
        public string GetFileName()
        {
            return null;
        }

        public void Show()
        {
            if (ebook == null)
                ebook = new RealEbook(FileName);
            ebook.Show();
        }
    }
}
