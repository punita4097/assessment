using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    /*An abstract class is a special type of class that cannot be instantiated.
     * An abstract class is designed to be inherited by subclasses that either implement or override its methods.
     * 
     * 
     * An abstract class abstract and non abstract methods can exist but not in the interface
     * */
    public abstract class Abs
    {
        public abstract void fun1();
    }
    public class First : Abs
    {
        public override void fun1()//abstract method in derived class is defined using override keyword 
        {
            Console.WriteLine("first definition of abstract method");
        }
    }
    public class Second : Abs
    {
        public override void fun1()
        {
            Console.WriteLine("second definition of abstract method");
        }
    }
}
