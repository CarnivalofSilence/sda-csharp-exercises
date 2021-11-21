using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class LineSegment
    {

        private List<MyPoint> points = new List<MyPoint>();

        public LineSegment(MyPoint a, MyPoint b)
        {
            points.Add(a);
            points.Add(b);
        }

        public LineSegment(int xa, int ya, int xb, int yb)
        {
            points.Add(new MyPoint(xa, ya));
            points.Add(new MyPoint(xb, yb));
        }

        public double Length()
        {
            return Math.Sqrt(Math.Pow(points[1].X - points[0].X, 2) + Math.Pow(points[1].Y - points[0].Y, 2));
        }
    }
}
