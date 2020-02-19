using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentIntro
{
    class Q3
    {
        public void vowel_constant() 
        {
            Console.WriteLine("Enter a character:");
            char c = Convert.ToChar(Console.ReadLine());
            char ch = char.ToLower(c);
            Console.WriteLine("using switch case");
            switch(ch) //using switch case
            {
                case 'a':
                    Console.WriteLine("Vowel:" + ch);
                    break;
                case 'e':
                    Console.WriteLine("Vowel:" + ch);
                    break;
                case 'i':
                    Console.WriteLine("Vowel:" + ch);
                    break;
                case 'o':
                    Console.WriteLine("Vowel:" + ch);
                    break;
                case 'u':
                    Console.WriteLine("Vowel:" + ch);
                    break;
                default:
                    Console.WriteLine("Constant:" + ch);
                    break;
            }
            Console.WriteLine("using for loop");
            if (ch=='a' || ch=='e' || ch=='i' || ch=='o' || ch=='u') //using if_else
            {
                Console.WriteLine("Vowel:" + ch);
            }
            else
            {
                Console.WriteLine("Constant:" + ch);
            }
        }
        


    }
}
