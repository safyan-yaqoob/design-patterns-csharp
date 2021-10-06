using System;
using System.Collections.Generic;
using System.Text;

namespace Memento_Pattern
{
    public class Edittor
    {
        private string Content { get; set; }

        public void setContent(string content)
        {
            this.Content = content;
        }
        public string getContent()
        {
            return this.Content;
        }

        public EditorState CreateState()
        {
            return new EditorState(this.Content);
        }
        public void Restore(EditorState state)
        {
            this.Content = state?.getContent();
        }
    }
}
