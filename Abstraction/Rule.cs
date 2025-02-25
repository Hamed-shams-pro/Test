using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Rule : Human
    {
        public string Name { get; init; }
        public string Family { get; init; }
        public string PrintInfo()
        {
            return $"{Name} {Family} {EyeColor} {Higth}";
        }
    }
}
