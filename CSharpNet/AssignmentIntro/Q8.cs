using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q8
    {
        public void table()
        {
            int i, j;
            for(i=1;i<=5;i++)
            {
                Console.WriteLine("Table of " + i);
                for (j=1;j<=10;j++)
                {
                    
                    Console.WriteLine("{0} * {1} = {2}", i, j, i * j);
                }
            }
        }
    }
}
