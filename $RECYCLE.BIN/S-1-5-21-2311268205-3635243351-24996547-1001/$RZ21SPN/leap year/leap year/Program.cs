﻿using System;

namespace leap_year
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("enter the year to check the year is leap year or not");
          int year = Convert.ToInt32(Console.ReadLine());
                if((year%4==0)&&(year%100!=0)||(year%400==0))
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
