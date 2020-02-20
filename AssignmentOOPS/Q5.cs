using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q5
    {
        public virtual void Name()
        {
            Console.WriteLine("####VIRTUAL METHOD####");
            Console.WriteLine("Virtual method are the methods that can be override in the derived class.To override a method in the derived class base class virtual method should contain 'virtual' keyword");
            Console.WriteLine("Name() called from base class having virtual keyword in it's signature.");
        }
    }
    class Q5Derived:Q5
    {
        public override void Name()
        {
            base.Name();
            Console.WriteLine("Name() called from derived class having override keyword in it's signature.");

        }
    }
}
