using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string passwordGuess = "s3cr3t!";
            if (password == passwordGuess) Console.WriteLine("Welcome");
            else Console.WriteLine("Wrong password!");
        }
    }
}
