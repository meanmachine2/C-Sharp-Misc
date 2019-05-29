using System;

namespace TaxCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Unesiote status : ");
            int status = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite zaradu : ");
            int zarada = int.Parse(Console.ReadLine());
            double tax = 0;
            if (status == 1)
            {
                if (zarada <= 8350) tax = zarada * 0.1;
                else if (zarada <= 33950) tax = (8350.0 * 0.1) + (zarada - 8350) * 0.15;
                else if (zarada <= 82250) tax = (8350.0 * 0.1) + (33950 - 8350) * 0.15 + (zarada - 33950) * 0.25;
            }
            Console.WriteLine(tax);

        }
    }
}
