using System.Security.Cryptography;

namespace StructsApp
{
    public struct Point
    {

        public double X { get;}

        public double Y { get;}

        public Point(double x, double y)
        { 
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }

        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;
            return Math.Sqrt( dx * dx + dy * dy );
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10,20);
            p1.Display();


            Point p2 = new Point(15, 30);
            p1.Display();

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points: {distance:F2}");

            Console.ReadKey();


        }
    }
}
