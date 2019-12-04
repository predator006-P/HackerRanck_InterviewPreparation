using System;

namespace test
{
    class Program
    {
        protected byte Age;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello");

            myClass Person = new myClass("Béla");
            Console.WriteLine($"Hello {Person.name}");

            myClass Person2 = new myClass("Sanyi", 40);
            Console.WriteLine($"Hello {Person2.name}");

            string mi_a_fasz = "      Mi a fasz       ";
            Console.WriteLine($"[{mi_a_fasz.ToUpper()}]");
            Console.WriteLine($"[{mi_a_fasz.ToLower()}]");

            mi_a_fasz = mi_a_fasz.Replace("fasz", "geci?");
            Console.WriteLine($"[{mi_a_fasz}]");
        }
    }

    class myClass: Program
    {
        public string name;

        public myClass(string name)
        {
            this.name = name;
            this.Age = 10;
            Console.WriteLine($"{this.name} age is {this.Age}");
            Console.WriteLine($"Length of this.name is {this.name.Length}");
        }

        public myClass(string name, byte age)
        {
            this.name = name;
            this.Age = age;
            Console.WriteLine($"{this.name} age is {this.Age}");
        }
    }
}
