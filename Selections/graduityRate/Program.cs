using System;

namespace graduityRate
{
    class Program
    {
        static void Main(string[] args)
        {
            int subtotal = int.Parse(Console.ReadLine());
            int gratuityRate = int.Parse(Console.ReadLine());
            double rate = (subtotal * (double)gratuityRate) / 100;
            double total = rate + subtotal;
            Console.WriteLine("Gartuity is {0} and total is {1}", rate, total);

        }
    }
}
