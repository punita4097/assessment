using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class Prevent_override
    {
        public virtual void print()
        {
            Console.WriteLine("base class function");
        }
    }

    class Prevent_override_derived : Prevent_override
    {
        sealed public override void print()
        {
            base.print();
            Console.WriteLine("Derived class function");
        }
    }
    class Prevent_override_sub:Prevent_override_derived
    {
        //this function cannot be further override
       /* public override void print()
        {
            base.print();
            Console.WriteLine("Derived class function");
        }*/

    }
}
