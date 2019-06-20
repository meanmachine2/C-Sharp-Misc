using System;

namespace PointInRectangle2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter points:");
            double pointI = double.Parse(Console.ReadLine());
            double pointII = double.Parse(Console.ReadLine());
            if ((pointI <= (10 / 2.0)) && (pointII <= (5 / 2.0))) Console.WriteLine("Point is in the rectangle");
            else Console.WriteLine("Point is not the rectangle");
        }
    }
}
