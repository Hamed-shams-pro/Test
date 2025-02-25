using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Human
    {
        public int Higth { get; set; }
        public Color EyeColor { get; set; }
    }
    internal enum Color
    {
        Blue,
        Green,
        Black,
        Brown
    }

}
