using System;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter points:");
            int pointI = int.Parse(Console.ReadLine());
            int pointII = int.Parse(Console.ReadLine());
            double lengthFromCenter = Math.Sqrt(Math.Pow(pointI - 0, 2) + Math.Pow(pointII - 0,2));
            if (lengthFromCenter > 10) Console.WriteLine("Point is not in the circle");
            else Console.WriteLine("Point is in the circle");          
        }
    }
}
