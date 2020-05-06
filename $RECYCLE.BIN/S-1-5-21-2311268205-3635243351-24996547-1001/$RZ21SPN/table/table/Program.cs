using System;

namespace table
{
    class Program
    {
        void mul()
        {
            for (int i = 1; i <= 5; i++)
            {
                //Console.WriteLine("\t");
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(+i + " * " + j + "=" + i * j + "\n");

                }
                Console.WriteLine("*************************************************");

            }
        }
            static void Main(string[] args)
            {
            Program p = new Program();
            Console.WriteLine("Multiplication table from 1 to 5");
            p.mul();


        }

    }
}

