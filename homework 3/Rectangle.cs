using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Rectangle(double w, double h) : Figure
    {
        public override double Area() => w > 0 && h > 0 ? w * h : throw new Exception("w,h>0");
        public override double Perimeter() => 2 * (w + h);
    }

}
