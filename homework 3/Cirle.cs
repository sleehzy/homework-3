using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    internal class Cirle(double r) : Figure
    {
        public override double Area() => r > 0 ? Pi * r * r : throw new Exception("r>0");
        public override double Perimeter() => 2 * Pi * r;
    }

}
