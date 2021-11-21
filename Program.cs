using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPoint myPoint1 = new MyPoint(4, 6);
            MyPoint myPoint2 = new MyPoint(5, 3);

            LineSegment lineSegment1 = new LineSegment(myPoint1, myPoint2);
            Console.WriteLine(lineSegment1.Length());

            LineSegment lineSegment2 = new LineSegment(2, 4, 6, 7);
            Console.WriteLine(lineSegment2.Length());



        }
    }
}
