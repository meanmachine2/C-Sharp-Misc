using System;

/*
Write a program that prompts the user to enter
the number of students and each student’s name and score, and finally displays the
student with the highest score and the student with the second-highest score.
 */
namespace StudentsTwoHighestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int scoreBest = -1, scoreSecondBest = -2;
            string nameBest = "",nameSecondBset="";
            int finishedEntry = 0;
            do
            {
                Console.Write("Enter student name: ");
                string studentName = Console.ReadLine();
                Console.Write("Enter student score: ");
                int score = int.Parse(Console.ReadLine());
                if (score>scoreSecondBest)
                {
                    if (score>scoreBest)
                    {
                        int tempScore = scoreBest;
                        string tempName = nameBest;
                        scoreBest = score;
                        nameBest = studentName;
                        scoreSecondBest = tempScore;
                        nameSecondBset = tempName;
                    }
                    else
                    {
                        scoreSecondBest = score;
                        nameSecondBset = studentName;
                    }
                }
                Console.Write("if you are finished with entries, type 0 for exit, else type 1 to continue");
                finishedEntry = int.Parse(Console.ReadLine());
            } while (finishedEntry!=0);
            Console.WriteLine("Best student is {0} with score of {1}\n Second best student is {2} with a score of {3} ", nameBest, scoreBest, nameSecondBset, scoreSecondBest);
        }
    }
}
