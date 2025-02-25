using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    internal class Indexer
    {
        private string[] _array;
        public Indexer(int count)
        {
            _array = new string[count];
        }
        public string this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
    }
}
