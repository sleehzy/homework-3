using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework_3
{
    public class CompositeFigure : Figure
    {
        private readonly List<Figure> _parts = new();
        public int Count => _parts.Count;
        public void Add(Figure f) => _parts.Add(f);
        public override double Area() => _parts.Sum(p => p.Area());
        public override double Perimeter() => _parts.Sum(p => p.Perimeter());
    }

}
