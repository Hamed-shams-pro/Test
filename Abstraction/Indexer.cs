using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Indexer
    {
        private string[] array;
        public Indexer(int count)
        {
            array = new string[count];
        }
        public string this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {

                array[index] = value;
            }
        }
    }
}
