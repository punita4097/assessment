using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    public class Overloading
    {
        public int s, l, b, A;
        /*s variable for side of square
         * l for length of rectangle
         * b for breadth for rectangle
         * A for area of the figure
         */

        public void area(int a)//function to find the area of square

        {
            A = s * s;//calculation for area of square
            Console.WriteLine("Area of square is" + A);

        }
        public void area(int a, int b)//function to find the area of rectangle

        {
            A = l * b;//calculation for area of rectangle
            Console.WriteLine("Area of rectangle is" + A);
        }
        
        public void perform()

        {
            char m;//variable used when you are interested to find more area
            Console.WriteLine("Perform the Method overloading");
            Console.WriteLine("\nMenu");
            Console.WriteLine("Find the area of square");
            Console.WriteLine("Find the area of rectangle");

            do
            {
                Console.WriteLine("choose the options to find more area");
                int i = Convert.ToInt32(Console.ReadLine());

                switch (i)
                {
                    case 1:
                        Console.WriteLine("enter the side to find the area of square");
                        s = Convert.ToInt32(Console.ReadLine());
                        area(s);
                        break;

                    case 2:
                        Console.WriteLine("Enter the length and the breadth of the rectangle");
                        l = Convert.ToInt32(Console.ReadLine());
                        b = Convert.ToInt32(Console.ReadLine());
                        area(l, b);
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
