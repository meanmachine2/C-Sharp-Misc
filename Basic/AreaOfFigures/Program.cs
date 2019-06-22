using System;

namespace AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine();
            double a = 0;
            double b = 0;
            if (figure == "rectangle")
            {
                a = double.Parse(Console.ReadLine());
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", a * b);
            }
            else if (figure == "circle")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", 3.14 * Math.Pow(a, 2));
            }
            else if (figure == "square")
            {
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}", Math.Pow(a, 2));
            }
            else Console.WriteLine("Unknown figure");
        }
    }
}
