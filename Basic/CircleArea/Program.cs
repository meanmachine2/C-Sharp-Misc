using System;

namespace Problem_Circle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.14159265358979;
            double r = double.Parse(Console.ReadLine());
            double area = PI * r * r;
            double peremiter = 2 * r * PI;
            Console.WriteLine($"Area is {area}");
            Console.WriteLine($"Perimeter is {peremiter}");
        }
    }
}

