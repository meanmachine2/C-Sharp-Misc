using System;

namespace PointInTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter x of point");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("enter y of point");
            double y = double.Parse(Console.ReadLine()); //60
            if (x < 200 && y < 100)
            {
                if ((x + (2 * y)) < 200)
                {
                    Console.WriteLine("Point is in the circle");
                }
                else Console.WriteLine("Point is not in the circle");
            }
            else Console.WriteLine("Point is not in the circle");

        }
    }
}
