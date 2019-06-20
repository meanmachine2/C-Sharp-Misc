using System;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number : ");
            int broj = int.Parse(Console.ReadLine());
            if (broj % 5 == 0 && broj % 6 == 0) Console.WriteLine("Number is divisible by 5 and 6");
            else if (broj % 5 == 0 ^ broj % 6 == 0) Console.WriteLine("Number is divisible by 5 or 6");
            else Console.WriteLine("Number is not divisible by 5 or 6");
        }
    }
}
