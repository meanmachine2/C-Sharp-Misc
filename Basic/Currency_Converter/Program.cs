using System;

namespace Currency_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] currency = new string[] { "BGN", "USD", "EUR", "GBP" };
            double[] currencyValue = new double[] { 1, 1.79549, 1.95583, 2.53405 };
            double conversionSum = 0;
            Console.Write("Enter sum: ");
            double sum = double.Parse(Console.ReadLine());
            Console.WriteLine("Curreny selection: BGN, USD, EUR, GBP ");
            Console.Write("Enter input currency: ");
            string inputCurrency = Console.ReadLine();
            Console.Write("Enter output currency: ");
            string outputCurrency = Console.ReadLine();
            int outputField = 0, inputField = 0;
            for (int i = 0; i < 4; i++)
            {
                if (inputCurrency == currency[i]) inputField = i;
                if (outputCurrency == currency[i]) outputField = i;
            }
            conversionSum = Math.Round((sum * currencyValue[inputField]) / currencyValue[outputField],2);
            Console.WriteLine("{0} {1}",conversionSum,outputCurrency);
        }
    }
}
