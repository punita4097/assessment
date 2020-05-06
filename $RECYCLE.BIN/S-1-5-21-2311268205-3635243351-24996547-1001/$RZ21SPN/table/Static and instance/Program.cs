using System;

namespace Static_and_instance
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Instance_class obj = new Instance_class();
                      Console.WriteLine("static variable value:"+Static_class.a);
            Console.WriteLine("Instance variable value:"+obj.b);
        }
    }
    public class Static_class
    {
        static int s;
        public static int a = 2500;
    }
    public class Instance_class
    {
         public int b = 10;
    }
}
