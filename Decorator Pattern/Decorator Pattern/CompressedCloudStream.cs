using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator_Pattern
{
    public class CompressedCloudStream:Stream
    {
        private Stream _stream;
        public CompressedCloudStream(Stream stream)
        {
            _stream = stream;
        }
        public void Write(string data)
        {
            var compress = Compressed(data);
            _stream.Write(compress);
        }

        private string Compressed(string data)
        {
            return data.Substring(0, 5);
        }
    }
}
