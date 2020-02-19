using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class Access_specifier
    {
        public int a = 10;  //everywhere accessible
        private int b = 20; //accessible within class
        protected int c = 30;   //accessible within class and its derived class
       internal int d = 50;//by default access specifier is internal and its access privelige in within assembly
        protected internal int g = 400;//access within assembly and in it's derived class present in another assembly
        public void within_class()
        {   //class for the access specifier which are accessible in within class
            Console.WriteLine("private member:" + b);
            Console.WriteLine("public member:" + a);
            Console.WriteLine("Protected member:" + c);
            Console.WriteLine("Internal member:" + d);
            Console.WriteLine("Protected internal member:" + g);

        }


    }
    class Access_specifier2:Access_specifier
    { //class for the access specifier which are accessible in derived class
        public void within_derived()
        {
            Console.WriteLine("public member:" + a);
            Console.WriteLine("Protected member:" + c);
            Console.WriteLine("Internal member:" + d);
            Console.WriteLine("Protected internal member:" + g);

        }
    }
    class Access_specifier3
    {
        //class for the access specifier which are accessible in the assembly
        public void no_inherit()
        {
            Access_specifier obj = new Access_specifier();
            Console.WriteLine("public member:" + obj.a);
           
            Console.WriteLine("Internal member:" + obj.d);
            Console.WriteLine("Protected internal member:" + obj.g);

        }
    }
}
