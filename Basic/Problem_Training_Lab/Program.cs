using System;

namespace Problem_Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter length : ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Enter width : ");
            double width = double.Parse(Console.ReadLine());
            if (width <= 3 || width >= length || length >= 100)
              {
                Console.Write("again - Enter length : ");
                length = double.Parse(Console.ReadLine());
                Console.Write("again - Enter width : ");
                width = double.Parse(Console.ReadLine());
            }
            double columns = (length*100) / 120;
            double rows = ((width * 100) - 100) /70;
            int totalNumberofSeats = (int)columns * (int)rows - 3;
            Console.WriteLine("Total number of seats is " + totalNumberofSeats);
        }
    }
}
