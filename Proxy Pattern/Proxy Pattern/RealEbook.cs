using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy_Pattern
{
    public class RealEbook : EBook
    {
        private string FileName;
        public RealEbook(string fileName)
        {
            FileName = fileName;
            Load();
        }

        private void Load()
        {
            Console.WriteLine("Loading..." + FileName);
        }
        public string GetFileName()
        {
            return FileName;
        }

        public void Show()
        {
            Console.WriteLine("Showing the ebook" + FileName);
        }
    }
}
