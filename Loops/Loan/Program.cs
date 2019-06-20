using System;

namespace Loan
{
    class Program
    {
        static void Main(string[] args)
        {         
            double monthlyInterestRate = Convert.ToDouble(Console.ReadLine());
            int years = int.Parse(Console.ReadLine());
            double loanAmount = Convert.ToDouble(Console.ReadLine());
            monthlyInterestRate = (monthlyInterestRate / 100.0) / 12.0;
            double monthlyPayment = (loanAmount * monthlyInterestRate) / (1 - (1 / (Math.Pow(1 + monthlyInterestRate, (double)years * 12.0))));
            double totalPayment = monthlyPayment * years * 12;
            Console.WriteLine(monthlyPayment+" total "+totalPayment);
        }
    }
}
