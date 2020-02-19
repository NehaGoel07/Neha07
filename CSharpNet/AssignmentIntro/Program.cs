using System;

namespace AssignmentIntro
{
    class Program
    {
        public void leap_year()
        {
            Program p1 = new Program();
            Console.WriteLine("Enter year:");
            int year=Convert.ToInt32(Console.ReadLine());
            if(year%4==0)
            {
                Console.WriteLine("Leap year:"+year);
            }
            else
            {
                Console.WriteLine("Not a leap year:"+year);
            }

        }
    }
}
