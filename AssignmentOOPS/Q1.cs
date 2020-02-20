using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{

    //Abstract classes can contain both abstract as well as non abstract methods.They cannot be instantiated.
    public abstract class abstractClass
    {
        public abstract void abstractMethod();
    }

    //All the methods of interface are abstract by default.They cannot be instantiated.
    public interface inter1
    {
        void method1()
        {}
    }

    //Inheriting abstract class and interface and thus achieving multiple inheritence.
    class Q1:abstractClass,inter1
    {
       public void method1()
        {
            Console.WriteLine("Interface inter1 method method1.");
        }

        public override void abstractMethod()
        {
            Console.WriteLine("Hello from abstract method.");
        }
    }
}
