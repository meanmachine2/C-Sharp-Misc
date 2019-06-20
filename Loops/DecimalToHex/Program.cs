using System;

namespace DecimalToHex
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hex = new string[] { "0","1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D" };
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            string hexSolution = "";
            bool cond = true;
            while (cond)
            {              
                int remainder = number % 16;
                hexSolution = hex[remainder] + hexSolution;
                number /= 16;
                if (number == 0) cond = false;
            }
            Console.WriteLine("Converted to hex is " + hexSolution);          
        }
    }
}
