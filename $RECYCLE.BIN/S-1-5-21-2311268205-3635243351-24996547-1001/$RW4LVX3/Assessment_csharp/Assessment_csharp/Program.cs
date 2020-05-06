using System;

namespace Assessment_csharp
{
    class Program
    {
        static void Main(string[] args)

        {

            Char p;
            Console.WriteLine("Menu");
            Console.WriteLine("1. To show the difference between Static & Instance Member");
            Console.WriteLine("2. To find the leap year");
            Console.WriteLine("3. To find Constant & vowel using both Switch case ");
            Console.WriteLine("4. To find Constant & vowel using both if_else");
            Console.WriteLine("5. Boxing and unboxing concepts");
            Console.WriteLine("6. The scope of different access modifiers");
            Console.WriteLine("7. To reverse your full name without using an inbuilt function");
            Console.WriteLine("8. The multiplication table vertically from 1 to 5 ");
            do
            {
                Console.WriteLine("Choose anyone from above according to your choice");
                int c = Convert.ToInt32(Console.ReadLine());
                Constant_Vowel obj_find = new Constant_Vowel();
                switch (c)
                {
                    case 1:
                        Console.WriteLine("\n");

                        Static_instance obj = new Static_instance();
                        Console.WriteLine("Instance variable value:" + obj.b);
                        Console.WriteLine("static variable value:" + Static_instance.a);
                        break;
                    case 2:
                        Console.WriteLine("\n");

                        Leap obj_leap = new Leap();
                        obj_leap.lp();
                        break;
                    case 3:
                        Console.WriteLine("\n");

                        obj_find.find_using_Switch();
                        break;
                    case 4:
                        Console.WriteLine("\n");

                        obj_find.find_using_If_else();
                        break;
                    case 5:
                        Console.WriteLine("\n");
                        Box_unbox obj_box = new Box_unbox();
                        obj_box.boxing_unboxing();
                        break;
                    case 6:
                        Console.WriteLine("\n");

                        Access_specifier2 obj_access = new Access_specifier2();
                        Access_specifier3 obj_modifier = new Access_specifier3();
                        Console.WriteLine(" members are accessible with in a class:");
                        obj_access.within_class();
                        Console.WriteLine("\n\n");

                        Console.WriteLine("members are accessible within derived class");
                        obj_access.within_derived();
                        Console.WriteLine("\n\n");

                        Console.WriteLine("Members are accessible within a assembly");
                        obj_modifier.no_inherit();

                        break;
                    case 7:
                        Console.WriteLine("\n");

                        Reverse_name obj_rev = new Reverse_name();
                        obj_rev.reverse();
                        break;
                    case 8:
                        Console.WriteLine("\n");

                        table obj_table = new table();
                        Console.WriteLine("Multiplication table from 1 to 5");
                        obj_table.mul();

                        break;
                    default:
                        Console.WriteLine("\n");

                        Console.WriteLine("invalid choice");
                        break;
                }
                Console.WriteLine("\n");

                Console.WriteLine("Do you want to continue(y/n)");
                p = Convert.ToChar(Console.ReadLine());



            } while ((p == 'y') || (p == 'Y'));                 
            
            


        }
    }
}
