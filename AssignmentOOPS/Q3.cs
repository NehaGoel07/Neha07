using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    public interface interA
    {
        void msg() 
        { }
    }
    public interface inter2
    {
        void msg()
        { }
        
    }
    class Q3:interA,inter2
    {
        public void msg()

        {
            Console.WriteLine("Method of interface 1 and interface 2 are of same name which is being implemented in the class which is deriving both the interfaces.");
        }
    }
}
