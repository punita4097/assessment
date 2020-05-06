using System;

namespace Genericexample
{
    class generic<T>
    {
        public void add(T a, T b)
        {
           int aas= Convert.ToInt32(a);
            int sddd= Convert.ToInt32(b);
            Console.WriteLine();

            int result = aas + sddd;
           // return c;

        }
        public void sub(T a, T b)
        {
            Console.WriteLine(a - b);
            // return a - b;
        }
        
    }
    class Program:generic<T>
    {
        


        static void Main(string[] args)
        {
            generic<int> obj = new generic<int>();
            obj.add(5, 7);
            obj.sub(9, 8);

            Console.WriteLine("Hello World!");
        }
    }
}
