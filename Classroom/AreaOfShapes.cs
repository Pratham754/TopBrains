namespace AreaOfShapes
{
    abstract class Shape
    {
        public abstract double GetArea();
    }

    public class Circle(double r) : Shape
    {
        double radius = r;

        public override double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }

    public class Rectangle(double w, double h) : Shape
    {
        double width = w, height = h;

        public override double GetArea()
        {
            return width * height;
        }
    }

    public class Triangle(double b, double h) : Shape
    {
        double b = b, h = h;

        public override double GetArea()
        {
            return 0.5 * b * h;
        }
    }
    public class Program
    {
        public static void Main()
        {
            string[] shapes = [
                "C 3",
                "R 4 5",
                "T 6 2"
            ];

            double totalArea = ComputeTotalArea(shapes);
            Console.WriteLine(totalArea);
        }

        static double ComputeTotalArea(string[] shapes)
        {
            double total = 0;

            foreach (var s in shapes)
            {
                var parts = s.Split(' ');
                Shape shape = null;

                if (parts[0] == "C")
                    shape = new Circle(double.Parse(parts[1]));
                else if (parts[0] == "R")
                    shape = new Rectangle(
                        double.Parse(parts[1]),
                        double.Parse(parts[2]));
                else if (parts[0] == "T")
                    shape = new Triangle(
                        double.Parse(parts[1]),
                        double.Parse(parts[2]));

                if (shape != null)
                    total += shape.GetArea();
            }

            return Math.Round(total, 2, MidpointRounding.AwayFromZero);
        }
    }
}