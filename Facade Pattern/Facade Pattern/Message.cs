using System;
using System.Collections.Generic;
using System.Text;

namespace Facade_Pattern
{
    public class Message
    {
        private string _content;
        public Message(string content)
        {
            _content = content;
        }
    }
}
