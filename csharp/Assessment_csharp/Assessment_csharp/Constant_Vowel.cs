using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class Constant_Vowel
    {
        public int i;//variable which is used to continue or exit
        public void find_using_Switch()//function to check the consonant and vowel using switch case
        {
            
            do
            {
                Console.WriteLine("Enter any character");
            char ch = Convert.ToChar(Console.ReadLine());
                int i = ch;
                if ((i >= 48) && (i <= 57))
                {
                    Console.WriteLine("invalid input");
                    break;
                }
                else
                {

                    switch (ch)
                    {
                        case 'a':
                            Console.WriteLine(" It is a vowel");
                            break;
                        case 'e':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'i':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'o':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'u':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'A':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'E':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'I':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'O':
                            Console.WriteLine("It is a vowel");
                            break;
                        case 'U':
                            Console.WriteLine("It is a vowel");
                            break;

                        default:
                            Console.WriteLine("It is a consonant");
                            break;
                    }
                }
                Console.WriteLine("Do youwant to continue(1=yes/0=no)");
                 i= Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
           
        }

        public void find_using_If_else()//function to check the consonant and vowel using if else
        {
            do
            {
                Console.WriteLine("Enter the character");
            char ch = Convert.ToChar(Console.ReadLine());
                int i = ch;
                if ((i >= 48) && (i <= 57))
                {
                    Console.WriteLine("invalid input");
                    break;
                }

                else if (ch == 'a' || ch == 'A' || ch == 'e' || ch == 'E' || ch == 'i' || ch == 'I' || ch == 'o' || ch == 'O' || ch == 'u' || ch == 'U')
                {
                    Console.WriteLine("It is a vowel");
                }
              
                else
                {
                    Console.WriteLine("It is a consonant");
                }
                Console.WriteLine("Do youwant to continue(1=yes/0=no)");//enter 1 for continue and 0 to exit
                i = Convert.ToInt32(Console.ReadLine());
            }
            while (i == 1);
        }
    }
}
