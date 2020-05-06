using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    class Way_object
    {
        public Way_object()//parameter lass constructor
        {
            Console.WriteLine("parameterless constructor");
        }
        public Way_object(int a,int b)//parametrized constructor
        {
            a = a + b;
            Console.WriteLine("print addition of base" + a);

        }
        static Way_object()//static constructor
        {            Console.WriteLine("static constructor of base class");

        }
    }

    class Derived_way:Way_object
    {
        public Derived_way()//default cunstructor
        {
            Console.WriteLine("parameterless constructor");
        }

        public Derived_way(int a,int b)//parametrized constructor
        {
            a = a + b;
            Console.WriteLine("print addition" + a);

        }

        static Derived_way()//static cunstructor
        {
            Console.WriteLine("static constructor of derived class");

        }
    }


}
