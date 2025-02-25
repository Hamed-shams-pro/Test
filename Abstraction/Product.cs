using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal record Product(string Title, string Description);
    internal record Market(Product Product, int count)
    {
        public string Name { get; set; }
    }
}
