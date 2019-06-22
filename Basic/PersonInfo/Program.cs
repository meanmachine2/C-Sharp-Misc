using System;

namespace Problem_Person_Info
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string country = Console.ReadLine();
            string town = Console.ReadLine();
            Console.WriteLine($"{firstName} {lastName} from {country} - {town}!");
        }
    }
}
