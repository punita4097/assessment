using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    public class Parametrized_constructor
    {
        public Parametrized_constructor()
        {
            Console.WriteLine("parameterless constructor");
        }
        public Parametrized_constructor(int a,int b)
        {
            Console.WriteLine("\nparametrized constructor of base class");
        }
    }

    public class Parametrized_constructor_sub:Parametrized_constructor
    {
        public Parametrized_constructor_sub(int a, int b, int c) : base(a,b)
        {
            Console.WriteLine("\nparametrized constructor of derived class");
        }
    }
}
