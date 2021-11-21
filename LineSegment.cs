using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
	class LineSegment
	{
		public MyPoint A { get; set; }
		public MyPoint B { get; set; }



		public LineSegment(MyPoint a, MyPoint b)
		{
			A = a;
			B = b;
		}

		public LineSegment(double ax, double ay, double az, double bx, double by, double bz)
		{
			A = new MyPoint3D(ax, ay, az);
			B = new MyPoint3D(bx, by, bz);
		}

		public LineSegment(double ax, double ay, double bx, double by)
		{
			A = new MyPoint(ax, ay);
			B = new MyPoint(bx, by);
		}

		public double Lenght()
		{
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
		}

		public double Lenght3D()
		{
			MyPoint3D A3D = (MyPoint3D)A;
			MyPoint3D B3D = (MyPoint3D)B;
			return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2) + Math.Pow(B3D.Z - A3D.Z, 2));
		}

	}
}
