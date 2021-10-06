using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class EncryptedCloudStream:Stream
    {
        private Stream _stream;
        public EncryptedCloudStream(Stream stream)
        {
            _stream = stream;
        }

        public void Write(string data)
        {
            var encrypted = Encrypted(data);
            _stream.Write(encrypted);
        }

        private string Encrypted(string data)
        {
            return "*&ru58934753u89574332r()ot4";
        }
    }
}
