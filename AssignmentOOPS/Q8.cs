using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOPS
{
    //abstraction
    public abstract class Box
    {
        public abstract void items();
    }
    class Q8:Box
    {
        //Encapsulation
        int no_students = 10;
        public override void items()
        {
            int quant_pen,quant_books;
            quant_pen = 3;
            quant_books = 5;
            Console.WriteLine("No of pens and books in a box:" + quant_pen, +quant_books);
        }
        void list()
        {
            Console.WriteLine("Total no of students:" + no_students);
        }
    }
}
