using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sda_csharp_exercises
{
    class Circle : Shape
    {
        private const double Pi = 3.14;
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double GetArea()
        {
            return Pi * radius * radius;
        }
    }
}
