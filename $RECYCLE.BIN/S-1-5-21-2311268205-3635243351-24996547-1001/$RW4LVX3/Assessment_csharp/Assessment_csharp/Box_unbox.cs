using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_csharp
{
    class Box_unbox
    {
       public void boxing_unboxing()//function for boxing and unboxing
        {
            int a = 100;
            object box = a;//here boxing is done
            a = 800;
            Console.Write("boxing");
            Console.WriteLine(box);
            int unbox = (int)box;//here unboxing is done
            Console.Write("unboxing",unbox);
            Console.WriteLine(unbox);
        }
    }
}
