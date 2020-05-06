using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class Reverse_name//class to reverse the full name

    {
        public void reverse()//function to reverse the full name
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            char[] store = name.ToCharArray();
            int len = store.Length - 1;
            string revert = " ";
            for(int i=len;i>=0;i--)
            {
                revert = revert+ store[i];
            }
            Console.WriteLine("reverse name is");
            Console.WriteLine(revert);
        }


    }
}
