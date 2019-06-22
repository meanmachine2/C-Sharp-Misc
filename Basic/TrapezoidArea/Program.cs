using System;

namespace TrapezoidArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("b1 = ");
            double b1 = double.Parse(Console.ReadLine());
            Console.Write("b2 = ");
            double b2 = double.Parse(Console.ReadLine());
            Console.Write("h = ");
            double h = double.Parse(Console.ReadLine());
            double result = (b1 + b2) * h / 2.0;
            Console.WriteLine("Trapezoid area = {0}", result);
        }
    }
}
