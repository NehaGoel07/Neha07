using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q6
    {
        public virtual void method1() //adding virtual keyword to override the method
        {
            Console.WriteLine("base class mehod");
        }
    }
    class Q6Derived : Q6
    {
        public sealed override void method1() //adding sealed keyword so that the method cannot get override further
        {
            base.method1();
            Console.WriteLine("derived class override method");
            Console.WriteLine("'Q6b.method1()': cannot override inherited member 'Q6a.method1()' because it is sealed AssignmentOOPS");
        }
    }
    /*class Q6b : Q6Derived
    {
        public override void method1()
        { }
       
    }*/
}
      
    