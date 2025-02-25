using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Student : Person
    {
        private int _age;

        public override void IsValidate(int age)
        {
            if (age > 18)
            {
                _age = age;
                Console.WriteLine("OK");
            }
        }

        public override string PrintInfo()
        {
            return $"{Name} {Family} {_age}";
        }

        public override void Test()
        {

            base.Test(); 
            Console.WriteLine("OKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK");
        }

    }
}
