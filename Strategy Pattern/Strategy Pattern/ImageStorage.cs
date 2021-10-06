using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy_Pattern
{
    public class ImageStorage
    {
        private ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStorage(ICompressor compressor,IFilter filter)
        {
            _compressor = compressor;
            _filter = filter;
        }

        public void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Apply(fileName);
        }
    }
}
