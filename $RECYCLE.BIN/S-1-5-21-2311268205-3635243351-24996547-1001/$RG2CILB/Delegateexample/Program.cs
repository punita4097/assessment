using System;

namespace Delegateexample
{
    public delegate void adddelegate(int a, int b);
    public delegate void subtractdelegate(int a, int b);
    public delegate void multiplydelegate(int a, int b);
    class De
    {
       /* public void add(int a, int b)
        {
            Console.WriteLine(a + b);
        }*/
      /*  public void subtract(int a, int b)
        {
            Console.WriteLine(a - b);
        }
        
        */
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            De obj = new De();
            adddelegate d1;
           // adddelegate d1 = new adddelegate(obj.subtract);
            d1 = delegate (int a, int b)
            {
                Console.WriteLine(a + b);
            };
            d1+= delegate (int a, int b)
            {
                Console.WriteLine(a - b);
            };
            d1+= (a, b) => Console.WriteLine(a * b);
            


           // d1 += obj.subtract;
            d1(5, 6);
           // subtractdelegate d2 = new subtractdelegate(obj.subtract);

            //d1(5, 6);
            //d2(7, 1);

           
           // Console.WriteLine("Hello World!");
        }
    }
}
