using System;

namespace Multiple_Subtraction_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            string [] answers = new string[5];
            Random rand = new Random();
            int timeStart = DateTime.Now.Second;
            Console.WriteLine("You are presented with five math problems");
            int correctAnswer = 0;         
            for (int i = 0; i < answers.Length; i++)
            {
                int a = rand.Next(0, 10);
                int b = rand.Next(0, 10);
                int temp = 0;
                if (a<b)
                {
                    temp = a;
                    a = b;
                    b = temp;
                }
                int answer = a - b;
                Console.Write("{0} - {1} = ", a, b);
                int c = int.Parse(Console.ReadLine());
                if (c == answer)
                {
                    answers[i] = a + " - " + b + " = " + c + " - Correct!";
                    Console.WriteLine("Correct!");
                    correctAnswer++;
                }
                else
                {
                    Console.Write("Wrong, answer should be {0} - {1} = {2}", a, b, answer);
                    answers[i] = a + " - " + b + " = " + c + " - Wrong!";
                    Console.WriteLine();
                }
            }
            int timeStop = (int)(DateTime.Now.Second) - timeStart;
            Console.WriteLine("Test time is {0} seconds",timeStop);
            Console.WriteLine("Correct count is " + correctAnswer);
            for (int i = 0; i < answers.Length; i++)
            {
                Console.WriteLine(answers[i]);
            }
        }
    }
}
