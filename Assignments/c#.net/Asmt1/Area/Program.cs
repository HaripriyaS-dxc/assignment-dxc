using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static string[] Shapes = { "Square", "Triangle", "Rectangle", "Circle" };

        static void square()
        {
            Console.WriteLine("Enter the side");
            int s = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is:{0}",(s*s));
        }

        static void triangle()
        {
            Console.WriteLine("Enter the length and height");
            int l = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is:{0}", (0.5*l*h));
        }
        static void rectangle()
        {
            Console.WriteLine("Enter the length and breadth");
            int l = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is:{0}", (l*b));
        }

        static void circle()
        {
            Console.WriteLine("Enter the radius");
            int r = int.Parse(Console.ReadLine());
            Console.WriteLine("The area is:{0}", (Math.PI*r*r));
        }

        static void Main(string[] args)
        {
           

            Console.WriteLine("Choose from the following Shapes");

            foreach (var item in Shapes)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine();

            string shape = Console.ReadLine();

            switch(shape)
            {
                case "Square": Program.square(); break;
                case "Triangle": Program.triangle(); break;
                case "Rectangle": Program.rectangle(); break;
                case "Circle": Program.circle(); break;

            }


            Console.ReadLine();

        }
    }
}
