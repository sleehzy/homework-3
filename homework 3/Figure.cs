using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    abstract public class Figure
    {
        protected const double Pi = 3.14159265358979323846;
        public abstract double Area();
        public abstract double Perimeter();
    }
}
