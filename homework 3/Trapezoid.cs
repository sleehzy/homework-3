using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Trapezoid(double a, double b, double h, double c, double d) : Figure
    {
        public override double Area() => a > 0 && b > 0 && h > 0
            ? 0.5 * (a + b) * h : throw new Exception("a,b,h>0");
        public override double Perimeter() => a + b + c + d;
    }

}
