using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Rhomb(double s, double angle) : Figure
    {
        public override double Area() => s > 0 && angle > 0 && angle < Pi
            ? s * s * Math.Sin(angle) : throw new Exception("s>0, 0<angle<pi");
        public override double Perimeter() => 4 * s;
    }

}
