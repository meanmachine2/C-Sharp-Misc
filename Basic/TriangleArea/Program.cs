using System;

namespace Problem_Triangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double ha = double.Parse(Console.ReadLine());
            double area = (a * ha) / 2;
            Console.WriteLine(Math.Round(area, 2));
        }
    }
}
