using System;

namespace Assessment_of_oops
{
    class Program
    {
        static void Main(string[] args)
        {
            char c;
            Console.WriteLine("Menu");
            Console.WriteLine("1.Abstract class");
            Console.WriteLine("2. Interface class");
            Console.WriteLine("3. Method overloading");
            Console.WriteLine("4. Method overriding");
            Console.WriteLine("5. Inherited interfaces have conflicting method names");
            Console.WriteLine("6. The different ways a method can be overloaded ");
            Console.WriteLine("7.  Virtual method in c# ");
            Console.WriteLine("8.  Preventing Derived class from overriding virtual members");
            Console.WriteLine("9.  To for parameterised constructor and call the same from derived call ");
            Console.WriteLine("10.  To explain encapsulation ");
            Console.WriteLine("11. To explain abstraction");
            Console.WriteLine("12. Operator overloading");
            Console.WriteLine("13. Different way to check the instantiation of object");
            Console.WriteLine("\n");



            do
            {
                Console.WriteLine("Choose the option from the above menu");
                int ch = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (ch)
                {
                    case 1:
                        Abs obj_abstract;
                           obj_abstract = new First();
                        obj_abstract.fun1();
                        obj_abstract = new Second();
                        obj_abstract.fun1();
                        
                        break;
                    case 2:

                        Interface_class obj_interface = new Interface_class();
                        obj_interface.add();
                        obj_interface.show();
                        break;
                    case 3:
                        Overloading obj_overload = new Overloading();
                        obj_overload.perform();

                        break;
                    case 4:
                        Overriding obj_derived = new Derived();
                        obj_derived.print();
                        break;
                    case 5:
                        first i = new Inherited_interface(); 
                        i.print();
                        second j = new Inherited_interface();
                        j.print();
                        break;
                    case 6:

                        overloading_way obj_way = new overloading_way();
                        obj_way.perform();
                        break;
                    case 7:
                        Virtual_csharp obj_virtual = new Virtual_derived();
                        obj_virtual.print();
                        break;
                    case 8:
                        Prevent_override obj_prevent = new Prevent_override_derived();
                        obj_prevent.print();

                        break;
                    case 9:

                        Parametrized_constructor_sub obj_paramterized = new Parametrized_constructor_sub(4,5,6);


                        break;
                    case 10:
                        Encapsulation encapsulation = new Encapsulation();
                        encapsulation.product(5, 6);


                        break;
                    case 11:
                        Abstraction abstraction = new Abstraction();
                        abstraction.details();
                        break;

                    case 12:
                        Operator_overloading operator_Overloading = new Operator_overloading();
                        operator_Overloading.perform();
                           

                        break;

                    case 13:
                        Derived_way derived_Way = new Derived_way();
                        Derived_way derived_Way1 = new Derived_way(10, 20);
                        /* Not possible
                         * 
                        Derived_way derived_Way2 = new Way_object();*/
                        Way_object derived_way = new Derived_way();

                        /*
                         * not possible
                         * 
                        Derived_way derived_Way2 = new Way_object(10, 20);
                        */
                        break;
                    default:
                        Console.WriteLine("invalid choice");
                        break;

                }
                Console.WriteLine("\n");

                Console.WriteLine("Do u want to continue (y/n)");
                 c = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("\n");



            } while ((c == 'y') || (c == 'Y'));
        }
    }
}
