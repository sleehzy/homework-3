namespace homework_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var composite = new CompositeFigure();

            while (true)
            {
                Console.WriteLine("\n1-Треуг 2-Квадр 3-Ромб 4-Прямоуг 5-Парал 6-Трап 7-Круг 8-Эллипс 0-Выход");
                Console.Write("Выбор: ");
                if (!int.TryParse(Console.ReadLine(), out int k) || k == 0) break;

                try
                {
                    Figure f = k switch
                    {
                        1 => new Triangle(D("a="), D("b="), D("c=")),
                        2 => new Square(D("s=")),
                        3 => new Rhomb(D("s="), D("angle=")),
                        4 => new Rectangle(D("w="), D("h=")),
                        5 => new Parallelogram(D("a="), D("b="), D("angle=")),
                        6 => new Trapezoid(D("a="), D("b="), D("h="), D("c="), D("d=")),
                        7 => new Cirle(D("r=")),
                        8 => new Ellipse(D("a="), D("b=")),
                        _ => throw new Exception("нет пункта")
                    };
                    Console.WriteLine($"  S={f.Area():F3} P={f.Perimeter():F3}");
                    composite.Add(f);
                }
                catch (Exception e) { Console.WriteLine($"  Ошибка: {e.Message}"); }
            }

            Console.WriteLine($"\nФигур: {composite.Count} S={composite.Area():F3} P={composite.Perimeter():F3}");

            static double D(string p)
            {
                while (true)
                {
                    Console.Write(p);
                    if (double.TryParse(Console.ReadLine(), out var v)) return v;
                    Console.WriteLine("  нужно число");
                }
            }
        }
    }
}
