using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q7
    {
        
        public Q7(int a)
        {
            Console.WriteLine("value in bae class parameterised constructor:" + a);
        }
    }
    class Q7Derived:Q7
    {
        public Q7Derived() : base(2) //calling base class constructor from derived class constructor
        { }

    }
}
