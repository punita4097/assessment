using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment_of_oops
{
    public class Abstraction
    {

        private string name;
        private long mobile;
        private int id;

        public  void details()
        {
            Console.WriteLine("enter the name");
            name = Console.ReadLine();
            Console.WriteLine("enter the mobile number");
            mobile= long.Parse(Console.ReadLine());
            Console.WriteLine("enter the id");
            id = int.Parse(Console.ReadLine());
            
            Console.WriteLine("\nDetails are:\n" + id + "\n" + name + "\n"+mobile);
        }

        /*private member can not be accessed outside the class.
         * 
         * Hence this properties we can show the abstraction*/

        private void gender(){
            Console.WriteLine("here gender is present");
        }
        private void salary()
        {
            Console.WriteLine("salary is entered here");
        }

    }       
    
}
