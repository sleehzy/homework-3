using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Parallelogram(double a, double b, double angle) : Figure
    {
        public override double Area() => a > 0 && b > 0 && angle > 0 && angle < Pi
            ? a * b * Math.Sin(angle) : throw new Exception("a,b>0, 0<angle<pi");
        public override double Perimeter() => 2 * (a + b);
    }

}
