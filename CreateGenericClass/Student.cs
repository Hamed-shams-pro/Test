using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateGenericClass
{
    internal class Student : BaseEntity<int>
    {
        public string Name { get; set; }
        public string Family { get; set; }
        private int _age;
        public void PrintInfo()
        {
            Console.WriteLine($"Before (Id {Id} , Name : {Name} , Family : {Family})");
            Thread.Sleep(5000);
            Console.WriteLine($"After (Id {Id} , Name : {Name} , Family : {Family})");
        }
        public void GetAge(int age)
        {
            if (age > 18)
            {
                _age = age;
                Console.WriteLine(_age);
            }
        }
        public async Task PrintInfoAsync()
        {
            Console.WriteLine($"Before (Id {Id} , Name : {Name} , Family : {Family})");
           await Task.Delay(5000);
            Console.WriteLine($"After (Id {Id} , Name : {Name} , Family : {Family})");
        }
        public async Task GetAgeAsync(int age)
        {
            if (age > 18)
            {
                _age = age;
                Console.WriteLine(_age);
            }
        }
    }
}
