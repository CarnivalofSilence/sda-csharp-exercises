using System;

namespace sda_csharp_exercises
{
    class Program
    {
			static void Main(string[] args)
			{
				MyPoint myPoint1 = new MyPoint(2, 3);
				MyPoint myPoint2 = new MyPoint(5, 2);

				MyPoint3D myPoint3 = new MyPoint3D(2, 3, 5);
				MyPoint3D myPoint4 = new MyPoint3D(5, 2, 1);

				LineSegment lineSegment1 = new LineSegment(myPoint1, myPoint2);
				LineSegment lineSegment2 = new LineSegment(2, 3, 5, 2);

				Console.WriteLine(lineSegment1.Lenght());

				Console.WriteLine(lineSegment2.Lenght());

				LineSegment lineSegment3 = new LineSegment(myPoint3, myPoint4);
				LineSegment lineSegment4 = new LineSegment(2, 3, 5, 5, 2, 1);

				Console.WriteLine(lineSegment3.Lenght3D());

				Console.WriteLine(lineSegment4.Lenght3D());

			}
		}
	}
