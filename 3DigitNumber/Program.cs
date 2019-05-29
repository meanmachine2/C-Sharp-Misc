using System;

namespace _3DigitNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Random ran = new Random();
            int number1 = ran.Next(0,9);
            int number2 = ran.Next(0, 9);
            int number3 = ran.Next(0, 9);
            Console.WriteLine(number1 + "" + number2 + "" + number3);
            int unos = int.Parse(Console.ReadLine());
            int j = 0;
            if (number1 == unos/100 && number2 == ((unos / 10) % 10) && number3 == unos % 10)
            {
                Console.WriteLine("Pogodili ste lutriju");
                j++;
            }
            if (j == 0)
            {
                if (number1 == (unos / 100) || number1 == ((unos / 10) % 10) || number1 == (unos % 10)) j++;
                if (number2 == (unos / 100) || number2 == ((unos / 10) % 10) || number2 == (unos % 10)) j++;
                if (number3 == (unos / 100) || number3 == ((unos / 10) % 10) || number3 == (unos % 10)) j++;
            }
            if (j==3) Console.WriteLine("Pogodili ste brojeve ali ne i redoslijed");
            else if (j>0) Console.WriteLine("Pogodili ste barem jedan broj");
            else Console.WriteLine("nista");
        }
    }
}
