using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record
{
    internal record Student(string Name, string Family)
    {
        public string[] Mobile { get; init; }
    }
}
