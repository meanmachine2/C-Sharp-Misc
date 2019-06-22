using System;

namespace Problem_Money
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Bitcoin : ");
            int bitcoin =int.Parse(Console.ReadLine());
            Console.Write("Enter yuan : ");
            double yuan = double.Parse(Console.ReadLine());
            Console.Write("Enter comission : ");
            double comission = double.Parse(Console.ReadLine());
            double sumEuros = ((bitcoin * 1168) + ((yuan * 0.15) * 1.76)) / 1.95;
            double commissionSum = sumEuros * (comission / 100);
            Console.WriteLine("Sum is {0}", sumEuros - commissionSum);
        }
    }
}
