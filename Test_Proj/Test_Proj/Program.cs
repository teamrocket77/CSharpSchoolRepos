using System;
using System.Threading;

namespace Test_Proj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");           
        }
    }
    class Person
    {
        public string name { get;  }
        public int age { get; private set; }
        public int SSN { get; }
        public Person(string name)
        {
            this.name = name;
        }
        public void IncrementAge()
        {
            age += 1;
        }
    }
}
