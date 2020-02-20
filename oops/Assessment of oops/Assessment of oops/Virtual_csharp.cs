using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class Virtual_csharp
    {
        /* Virtual  keyword is used in the c# to override the function.
         * we use the virtual keyword with those function where we need to redefine the same function in the derived class
         * without using virtual keyword with the function declaration we can't define the function of same name
         * in derived class
         * 
         
         */
     

        public virtual void print()
        {
            Console.WriteLine("base class function");
        }
    }
    class Virtual_derived:Virtual_csharp
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("Derived class function");
        }
    }
}
