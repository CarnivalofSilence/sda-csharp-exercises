using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    interface Shape
    {
        public double GetArea();
        public static double GetTotalArea(List<Shape> shapes)
        {
            double total = 0;

            foreach (Shape shape in shapes)
            {
                total += shape.GetArea();
            }
            return total;
        }
    }
}
