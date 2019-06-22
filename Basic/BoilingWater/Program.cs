using System;

namespace BoilingWater
{
    class Program
    {
        static void Main(string[] args)
        {
            double waterTemperature = double.Parse(Console.ReadLine());
            if (waterTemperature > 100) Console.WriteLine("The water is boiling");
            else Console.WriteLine("The water is not hot enough");
        }
    }
}
