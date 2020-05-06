using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{

    /*
     * It is like abstract class because all the methods which are declared inside the interface are abstract methods. 
     * It cannot have method body and cannot be instantiated.
     * It is used to achieve multiple inheritance which can't be achieved by class.
     * */
    interface first
    {
         void print();//by default method in the interface are abstract and public. no need to declare abstract explicitly

    }
    interface second
    {
         void print();
    }

    /*class inherit the both interfaces which are defined above and 
    the method which declare in interface are defined in this class
    */
    class Inherited_interface:first,second
    {
        void first.print()//definition of first interface
        {
            Console.WriteLine("first interface print method");
        }
        void second.print()//definition of second interface
        {
            Console.WriteLine("second interface print method");
        }
    }
}
