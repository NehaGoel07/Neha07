using System;

namespace AssignmentOOPS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q1:Abstract class and interface");
            Console.WriteLine("****************************************");
            Q1 abstractObj = new Q1();
            abstractObj.method1();
            abstractObj.abstractMethod();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q2:Overloading and Overriding");
            Console.WriteLine("****************************************");
            Q2Derived overLR = new Q2Derived();
            overLR.mul();
            overLR.mul(2, 5, 1);
            overLR.sum();
            Console.WriteLine("\n********************************************");
            Console.WriteLine("Q3:Interfaces having conflicting method name");
            Console.WriteLine("**********************************************");
            Q3 same = new Q3();
            same.msg();
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q4:Different methods of overloading");
            Console.WriteLine("****************************************");
            Q4 overLoading = new Q4();
            overLoading.calc(8,7,4);
            overLoading.calc(8, 7, 4,2);
            overLoading.calc(7, 2.5,1);
            overLoading.calc(1,2.5, 7);
            Console.WriteLine("\n****************************************");
            Console.WriteLine("Q5:use of virtual keyword");
            Console.WriteLine("****************************************");
            Q5Derived virt = new Q5Derived();
            virt.Name();
            Console.WriteLine("\n**********************************");
            Console.WriteLine("Q6:avoiding method to be override");
            Console.WriteLine("*********************************");
            Q6Derived over = new Q6Derived();
            over.method1();
            Console.WriteLine("\n*********************************************************************");
            Console.WriteLine("Q7:calling parameterised constructor of base class from derived class");
            Console.WriteLine("*********************************************************************");
            Q7Derived param_ctor = new Q7Derived();
            Console.WriteLine("\n*********************************");
            Console.WriteLine("Q8:Encapsulation and abstraction");
            Console.WriteLine("********************************");
            Q8 encap_abst = new Q8();
            encap_abst.items();
            //encap_abst.list(); //cannot access list() because it is a private method of class Q8
            Console.WriteLine("\n************************************");
            Console.WriteLine("Q9:Creating objects in different ways");
            Console.WriteLine("*************************************");
            Q9Derived normal = new Q9Derived();
            Q9Derived param = new Q9Derived(20);
            //Q9Derived refer = new Q9(); // cannot create an object of derived class giving reference of derived class
            Q9 baseObj = new Q9Derived();
            Console.WriteLine("\n************************************");
            Console.WriteLine("Q10:Operator Overloading");
            Console.WriteLine("*************************************");
            Q10 opOverload = new Q10(5);
            Q10 opOverload1 = new Q10(7);
            if(opOverload==opOverload1)
            {
                Console.WriteLine("Equal");
            }
            else
            {
                Console.WriteLine("Not Equal");
            }


        }
    }
}
