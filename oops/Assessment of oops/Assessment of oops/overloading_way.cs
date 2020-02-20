using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class overloading_way
    {

        

        public void area(int a)//function to find the area of square of natural number

        {
            a= a* a;//calculation for area of square
            Console.WriteLine("Area of square is" + a);

        }
        public void area(int a, int b)//function to find the area of rectangle of natural number

        {
            a = a * b;//calculation for area of rectangle
            Console.WriteLine("Area of rectangle is" + a);
        }

        public void area(float a)//function to find the area of square of decimal number

        {
            a = a * a;//calculation for area of square
            Console.WriteLine("Area of square is" + a);


        }

        public void area(float a, float b)//function to find the area of rectangle of decimal number

        {
            a = a * b;//calculation for area of rectangle
            Console.WriteLine("Area of rectangle is" + a);
        }
        public void perform()

        {
            char m;//variable used when you are interested to find more area
            Console.WriteLine("Method can be overloaded in two ways \n"+"1.by changing the number of parameter\n"+
                "2.By changing the datatype of the parameter");
            Console.WriteLine("Perform the Method overloading");
            Console.WriteLine("\nMenu");
            Console.WriteLine("1. Find the area of square using natural number");
            Console.WriteLine("2. Find the area of rectangle using natural number");
            Console.WriteLine("3. Find the area of square using decimal number");
            Console.WriteLine("4. Find the area of rectangle using decimal number");

            do
            {
                Console.WriteLine("choose the options to find more area");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("enter the side to find the area of square of ");
                       int a = Convert.ToInt32(Console.ReadLine());
                        area(a);
                        break;

                    case 2:
                        Console.WriteLine("Enter the length and the breadth of the rectangle");
                        int l = Convert.ToInt32(Console.ReadLine());
                       int  b = Convert.ToInt32(Console.ReadLine());//take user input in nextline always
                        area(l, b);
                        break;
                    case 3:
                        Console.WriteLine("enter the side to find the area of square  ");
                        float c = float.Parse(Console.ReadLine());
                        area(c);
                        break;
                    case 4:
                        Console.WriteLine("Enter the length and the breadth of the rectangle");
                        float L = float.Parse(Console.ReadLine());
                        float B = float.Parse(Console.ReadLine());
                        area(L, B);
                        break;


                    default:
                        Console.WriteLine("invalid choice");
                        break;


                }
                Console.WriteLine("Do you want to find more area(y/n)");//press y for continue and n for exit
                m = Convert.ToChar(Console.ReadLine());
            }
            while ((m == 'y') || (m == 'Y'));
        }

        

        


    }
}
