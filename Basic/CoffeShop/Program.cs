using System;

namespace CoffeShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string drink = Console.ReadLine();
            string extraSugar = Console.ReadLine();
            double price = 0;
            if (drink == "coffee") price = 1.00;
            else if (drink == "rea") price = 0.60;
            if (extraSugar == "sugar") price += 0.40;
            Console.WriteLine("Final price: ${0:0.00}", price);
        }
    }
}
