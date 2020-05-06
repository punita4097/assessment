using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class table
    {
        public void mul()//function to print the multiplication from 1 to 5
        {
            
            for (int i = 1; i <= 5; i++)
            {
                
                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine(+i + " * " + j + "=" + i * j + "\n");

                }
                Console.WriteLine("*************************************************");

            }
        }
    }
}
