using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q9
    {
        public Q9()
        {
            Console.WriteLine("Base class constructor");
        }
        public Q9(int a)
        {
            Console.WriteLine("Base class parameterised constructor");
            Console.WriteLine("a:" + a);
        }
        static Q9()
        {
            Console.WriteLine("base class static constructor");
        }
    }
    class Q9Derived : Q9
    {
        public Q9Derived()
        {
            Console.WriteLine("Derived class constructor");
        }
        public Q9Derived(int b)
        {
            Console.WriteLine("Derived class parameterised constructor");
        }
        static Q9Derived()
        {
            Console.WriteLine("Derived class static constructor");
        }
    }
}
