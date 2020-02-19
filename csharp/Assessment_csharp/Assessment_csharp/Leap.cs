using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class Leap
    {
        public void lp()//function to find the leap year
        {
            Console.WriteLine("enter the year to check the year is leap year or not");
            int year = Convert.ToInt32(Console.ReadLine());
            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))//conditions to check the leap year
            {
                Console.WriteLine("This is a leap year: " + year);
            }
            else
            {
                Console.WriteLine("This is not a leap year:" + year);
            }
        }
    }
}
