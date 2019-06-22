using System;

namespace Problem_Vegetable_Market
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter vegetable price per kilogram: ");
            double vegetablePrice = double.Parse(Console.ReadLine());
            Console.Write("Enter fruit price per kilogram: ");
            double fruitPrice = double.Parse(Console.ReadLine());
            Console.Write("Enter vegetable kilograms: ");
            int vegeKilos = int.Parse(Console.ReadLine());
            Console.Write("Enter fruit kilograms: ");
            int fruitKilos = int.Parse(Console.ReadLine());
            double vegeCost = vegetablePrice * vegeKilos;
            double fruitCost = fruitKilos * fruitPrice;
            double earnings = (vegeCost + fruitCost) / 1.94;
            Console.WriteLine("Total earnings = {0} EUR", earnings);
        }
    }
}
