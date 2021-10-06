using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Pattern
{
    public class EditorState
    {
        public EditorState(string Content)
        {
            this.Content = Content;
        }
        private string Content;
        public string content
        {
            set
            {
                if(this.Content==null)
                    this.Content = value;
            }
            get
            {
                return this.Content;
            }
        }

        public string getContent()
        {
            return this.Content;
        }
    }
}
