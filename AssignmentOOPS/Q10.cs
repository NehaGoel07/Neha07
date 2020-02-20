using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace AssignmentOOPS
{

    public class Q10
    {
        public int num1;
        public Q10(int input)
        {
            num1 = input;
        }
        public static bool operator == (Q10 numA, Q10 numB)
        {
            if (numA.num1 == numB.num1)
                return true;
            else
                return false;
        }
        public static bool operator != (Q10 numA, Q10 numB)
        {
            if(numA.num1 != numB.num1)
                return true;
            else
                return false;
        }
    }
}
