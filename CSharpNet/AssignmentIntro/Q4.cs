using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q4
    {
        public void boxing_unboxing()
        {
            int n = 20;
            Object obj = n; // boxing
            Console.WriteLine("variable value type value:" + n);
            Console.WriteLine("Object reference type value:" + obj);
            int num = (int)obj; //unboxing
            Console.WriteLine("Unboxing variable value:"+num);
        }
    }
}
