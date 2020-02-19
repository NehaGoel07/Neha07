using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q6
    {
        private int var1 = 10;
        public int var2 = 20;
        protected int var3 = 30;
        internal int var4 = 40;
        protected internal int var5=50;
        public void scope()
        {
            Console.WriteLine("accessing from same class");
            Console.WriteLine("private variable var1 consists of value:" + var1);
            Console.WriteLine("public variable var2 consists of value:" + var2);
            Console.WriteLine("protected variable var3 consists of value:" + var3);
            Console.WriteLine("internal variable var4 consists of value:" + var4);
            Console.WriteLine("protected internal variable var5 consists of value:" + var5);

        }
    }
    class Q6a:Q6
    {
        public void scopeDerived()
        {
            Console.WriteLine("\n\nAccessing from derived class");
            Console.WriteLine("cannot acess var 1 from derived class because it is private");
            Console.WriteLine("public variable var2 consists of value:" + var2);
            Console.WriteLine("protected variable var3 consists of value:" + var3);
            Console.WriteLine("internal variable var4 consists of value:" + var4);
            Console.WriteLine("protected internal variable var5 consists of value:" + var5);

        }
    }
}
