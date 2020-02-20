using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    class Q4
    {
        
        public void calc(int val1,int val2,int val3)
        {
            Console.WriteLine("output of {0}+{1}-{2} is:{3}", val1, val2, val3, val1 + val2 - val3);
        }
        //overloading by changing the number of parameters
        public void calc(int val1,int val2,int val3,int val4)
        {
            Console.WriteLine("METHOD 1:overloading by changing the number of parameters");
            Console.WriteLine("output of {0}+{1}-{2}*{3} is:{4}", val1, val2, val3, val4,val1 + val2 - val3 * val4);
        }

        //overloading by changing data type of parameters
        public void calc(int val1,double val2,int val3 )
        {
            Console.WriteLine("METHOD 2:overloading by changing data type of parameters");
            Console.WriteLine("output of {0}+{1}-{2} is:{3}", val1, val2,val3, val1 + val2-val3);
        }

        //overloading by changing the order of parameters
        public void calc( double val2, int val3,int val1)
        {
            Console.WriteLine("METHOD 3:overloading by changing the order of parameters");
            Console.WriteLine("output of {0}+{1}*{2} is:{3}", val1, val2,val3, val1 + val2*val3);
        }
    }
}
