using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Ellipse(double a, double b) : Figure
    {
        public override double Area() => a > 0 && b > 0 ? Pi * a * b : throw new Exception("a,b>0");
        public override double Perimeter()
            => Pi * (3 * (a + b) - Math.Sqrt((3 * a + b) * (a + 3 * b)));
    }

}
