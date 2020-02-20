using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q2
    {
        public void mul()
        {
            int a, b;
            a = 5;
            b = 9;
            Console.WriteLine("product of two numbers:"  +a * b);
        }
        public void mul(int a,int b,int c) //overloading mul method
        {
            Console.WriteLine("product of three numbers:" + a * b * c);
            Console.WriteLine("######METHOD OVERLOADING######");
            Console.WriteLine("Method overloading:functions having same name but different parameters");
        }
        public virtual void sum()
        {
            int x, y;
            x = 2;
            y = 4;
            Console.WriteLine("Sum of 2 and 4 is:" + (x + y));
        }
    }
    class Q2Derived:Q2
    {
        public override void sum()
        {
            base.sum();
            int num1, num2, num3;
            num1 = 2;
            num2 = 4;
            num3 = 6;
            Console.WriteLine("sum of 2,4 and 6 is:" + (num1 + num2 + num3));
            Console.WriteLine("######METHOD OVERRIDING######");
            Console.WriteLine("Method Overriding:Funtions having same name but different parameters.It is used in inheritence.Base class function should have 'virtual/abstract' keyword and derived class constructor should have 'override' keyword");
        }
    }
}
