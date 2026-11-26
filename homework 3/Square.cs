using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class Square(double s) : Figure
    {
        public override double Area() => s > 0 ? s * s : throw new Exception("s>0");
        public override double Perimeter() => 4 * s;
    }

}
