using System;

namespace RcokPaperSc
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rend = new Random();
            int compUnos = rend.Next(0, 2);
            string[] balance = new string[3] { "scissors", "rock", "paper" };
            Console.WriteLine("Enter numbers scissor (0), rock (1), paper (2): ");
            int unos = int.Parse(Console.ReadLine());           
            int racunalo = 0, covjek = 0;          
            if (unos == compUnos) Console.WriteLine("Equal entry");
            else if ((unos==2&&compUnos==1)||(unos==1&&compUnos==0)||(unos==0&&compUnos==2))
            {
                Console.WriteLine("{0} beats {1}", balance[unos], balance[compUnos]);
                covjek++;
            }
            else
            {
                Console.WriteLine("{0} beats {1}", balance[compUnos], balance[unos]);
                racunalo++;
            }
            if (racunalo >= 1) Console.Write("Computer Wins");
            else Console.Write("Player Wins");
        }
    }
}
