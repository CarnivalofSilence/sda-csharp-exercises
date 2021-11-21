using System;
using System.Collections.Generic;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
           

            List<Shape> shapes = new List<Shape>();
            Square square = new Square(4);
            Circle circle = new Circle(3);

            shapes.Add(square);
            shapes.Add(circle);

            double total = 0;
            foreach (Shape a in shapes)
            {
                total += a.GetArea();
            }

            Console.WriteLine(total);

        }
    }
}
