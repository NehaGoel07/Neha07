using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q7
    {
        public void reverse()
        {
            int i;
            String rev="";
            String name = "Neha";
            Console.WriteLine("Name:" + name);
            char[] c = name.ToCharArray();
            i = c.Length-1;
            while(i>=0)
            {
                rev = rev + c[i];
                i--;
            }
            Console.WriteLine("reverse name:"+rev);
        }
    }
}
