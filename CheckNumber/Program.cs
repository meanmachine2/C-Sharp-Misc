using System;

namespace CheckNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("unesi broj : ");
            int broj = int.Parse(Console.ReadLine());

            if (broj % 5 == 0 && broj % 6 == 0) Console.WriteLine("Broj je djeljiv sa 5 i 6");
            else if (broj % 5 == 0 ^ broj % 6 == 0) Console.WriteLine("Broj je djeljiv sa 5 ili 6");
            else Console.WriteLine("Broj nije djeljiv");
        }
    }
}
