using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class Operator_overloading
    {
        public void add(int a, int b)//function to add integer

        {
            a = a + b;//addition calculations
            Console.WriteLine("Additon of integer:\t" + a);

        }
        public void add(string a, string b)//function to add string

        {
            a = a + b;//string concatenation
            Console.WriteLine("string concatenation:\t" + a);
        }

        public void perform()
        {

            add(7, 9);
            add("punita", "yadav");

        }

        

    }

}

