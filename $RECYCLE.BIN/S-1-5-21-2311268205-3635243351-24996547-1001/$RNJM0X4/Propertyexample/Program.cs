using System;

namespace Propertyexample
{
    class Circle
    {
        private int _radius;

        public int radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }

        }

    }
    class Program:Circle
    { 
        static void Main(string[] args)

        {
            Circle c = new Circle();
            c.radius = 10;
            int _radius = c.radius;
            Console.WriteLine(_radius);
            c.radius = 34;
            Console.WriteLine(c.radius);
        }
    }
}
