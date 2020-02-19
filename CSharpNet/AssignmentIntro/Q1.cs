using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q1
    {
        public static int var; //static member
        static void disp()
        {
            var = 20;
            Console.WriteLine("Value of static member:" + var);
        }
        public void instance()
        {
            int var1 = 40; //instance member
            Console.WriteLine("value of instance variable:" + var1);
        }
        public static void Main(String[] args)
        {

            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q1:static and instance members");
            Console.WriteLine("****************************************");
            Q1 obj=new Q1();
            Q1.disp(); // accessing static methods with class name
            obj.instance(); //accessing instance member using object of class
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q2:Leap Year");
            Console.WriteLine("****************************************");
            Program leap = new Program();
            leap.leap_year();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q3:Constant or vowel");
            Console.WriteLine("****************************************");
            Q3 vowel = new Q3();
            vowel.vowel_constant();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q4:Boxing Unboxing");
            Console.WriteLine("****************************************");
            Q4 box = new Q4();
            box.boxing_unboxing();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q6:Scope of access modifiers");
            Console.WriteLine("****************************************");
            Q6a access = new Q6a();
            access.scope();
            access.scopeDerived();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q7:Reverse name");
            Console.WriteLine("****************************************");
            Q7 rev = new Q7();
            rev.reverse();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q8:Tables");
            Console.WriteLine("****************************************");
            Q8 mult = new Q8();
            mult.table();
        }
    }
    
}
