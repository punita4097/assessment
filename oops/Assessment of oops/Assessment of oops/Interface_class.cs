using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{

    /*
    * It is like abstract class because all the methods which are declared inside the interface are abstract methods. 
    * It cannot have method body and cannot be instantiated.
    * It is used to achieve multiple inheritance which can't be achieved by class.
    * Interface consists of number of abstrcat method 
    * */
    interface interface1
    {
        void add();
        void show();
    }
    class Interface_class : interface1
    {
        public int a, b, c;
        public void add()
        {
            a = 5; b = 6;
             c = a + b;

        }
        public void show()
        {
         Console.WriteLine("value of a and b: " + a+" "+b);

         Console.WriteLine("addition :" + c);
        }


    }
}
