using System;

namespace Tickets
{
    class Program
    {
        //student or regular
        static void Main(string[] args)
        {
            string ticketType = Console.ReadLine();
            if (ticketType == "student") Console.WriteLine("$1.00");
            else if (ticketType == "regular") Console.WriteLine("$1.60");
            else Console.WriteLine("Invalid ticket type!");
        }
    }
}
