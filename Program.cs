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
            Circle circle = new Circle(4);

            shapes.Add(square);
            shapes.Add(circle);

            Console.WriteLine(Shape.GetTotalArea(shapes));
        }
    }
}
