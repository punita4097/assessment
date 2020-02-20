using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class Overriding
    {
        public virtual void print()
        {
            Console.WriteLine("base class function");
        }
    }

    class Derived:Overriding
    {
        public override void print()
        {
            base.print();
            Console.WriteLine("Derived class function");
        }
    }
}
