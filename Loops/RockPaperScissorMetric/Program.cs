using System;

namespace RockPaperScissorMetric
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rend = new Random();
            int computerWin=0, playerWin = 0;
            while (computerWin<3&&playerWin<3)
            {
                int compEntry = rend.Next(0, 2);
                string[] balance = new string[3] { "scissors", "rock", "paper" };
                Console.Write("Enter numbers scissor (0), rock (1), paper (2): ");
                int entry = int.Parse(Console.ReadLine());
                int computer = 0, player = 0;
                if (entry == compEntry) Console.WriteLine("Equal entry");
                else if ((entry == 2 && compEntry == 1) || (entry == 1 && compEntry == 0) || (entry == 0 && compEntry == 2))
                {
                    Console.WriteLine("{0} beats {1}", balance[entry], balance[compEntry]);
                    player++;
                }
                else
                {
                    Console.WriteLine("{0} beats {1}", balance[compEntry], balance[entry]);
                    computer++;
                }
                //break
                if (computer >= 1)
                {
                    Console.Write("Computer Wins");
                    computerWin++;
                }
                else
                {
                    Console.Write("Player Wins");
                    playerWin++;
                }
                computer = 0;
                player = 0;
                Console.WriteLine();
            }          
        }
    }
}
