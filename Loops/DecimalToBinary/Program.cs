using System;

namespace DecimalToBinary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter decimal number: ");
            int entryNumber = int.Parse(Console.ReadLine());
            string binary = "";
            bool cond = true;
            while (cond)
            {
                if (entryNumber == 1) cond = false;
                if (entryNumber % 2 == 0)
                {
                    binary = 0 + binary;
                    entryNumber /= 2;
                }
                else
                {
                    binary = 1 + binary;
                    entryNumber /= 2;
                }
            }
            Console.WriteLine("Converted to binary : "+binary);
        }
    }
}
