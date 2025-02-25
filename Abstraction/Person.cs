using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal abstract class Person
    {
        public string Name { get; init; }
        public string Family { get; set; }
        //متد های ابسترکت بدنه در کلاس خودشان بدنه ندارند
        public abstract string PrintInfo();
        public abstract void IsValidate(int age);
        public virtual void Test()
        {
            Console.WriteLine("Test is complete");
        }
    }
}
