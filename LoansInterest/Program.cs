using System;

namespace LoansInterest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter loan amount: ");
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter number of years: ");
            int years = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine(String.Format("{0,-15} | {1,-15} | {2,5}", "Interest rate", "Montly Payment", "Total Payment"));
            for (double i = 5.000; i <= 8.000; i+=0.125)
            {
                double monthlyInterestRate =i;
                monthlyInterestRate = (monthlyInterestRate / 100.0) / 12.0;
                double monthlyPayment = Math.Round((loanAmount * monthlyInterestRate) / (1 - (1 / (Math.Pow(1 + monthlyInterestRate, (double)years * 12.0)))),2);
                double totalPayment = Math.Round(monthlyPayment * years * 12,2);
                Console.WriteLine(String.Format("{0,-15} | {1,-15} | {2,5}", i, monthlyPayment, totalPayment));
            }
        }
    }
}
