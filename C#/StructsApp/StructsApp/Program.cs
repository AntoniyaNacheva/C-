namespace StructsApp
{
    public struct Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }

    public class PointClass
    {
        public int X { get; set; }
        public int Y { get; set; }

        public PointClass(int x, int y)
        {
            X = x;
            Y = y;
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }


    /*
    public struct Point
    {

        public double X { get; }
        public double Y { get; }

        public Point(double x, double y)
        {
            X = x;
            Y = y;
        }
        public double DistanceTo(Point other)
        {
            double dx = other.X - X;
            double dy = other.Y - Y;

            return Math.Sqrt(dx * dx + dy * dy);
        }
        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    */

    /*
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Display()
        {
            Console.WriteLine($"Point: ({X},{Y})");
        }
    }
    */

    internal class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 20);
            p1.Display();

            Point p2 = p1;
            p2.Display();
            p2.X = 25;
            Console.WriteLine("After changing p2.X to 25");
            p1.Display();
            p2.Display();

            Console.WriteLine("----------------------");

            Console.WriteLine("Now come the class objects");
            PointClass pC1 = new PointClass(1, 2);
            PointClass pC2 = pC1;
            pC1.Display();
            pC2.Display();

            pC2.X = 3;
            Console.WriteLine("After changing pC2.X to 3");
            pC1.Display();
            pC2.Display();

            bool isEqual = pC1.Equals( pC2 );
            Console.WriteLine("is it equal? " + isEqual);

            /*
            Point p1 = new Point(10, 20);
            p1.Display();

            Point p2 = new Point(20, 30);
           
            p2.Display();

            double distance = p1.DistanceTo(p2);

            Console.WriteLine($"Distance between points: {distance:F5}");
            */

            /*
            Point p1 = new Point(10,20);
            p1.Display();

            Point p2;
            p2.X = 10;
            p2.Y = 20;
            p2.Display();

            Point p3 = p1;
            p3.X = 50;
            p1.Display();
            p3.Display();
            */

            Console.ReadKey();
        }
    }
}
