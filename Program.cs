using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Game();
        }
        static void Scoreboard(int playerScore, int computerScore)
        {
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"| Player: {playerScore}  |  Computer: {computerScore} |");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("What would you like to throw?");
            Console.WriteLine("1) Rock");
            Console.WriteLine("2) Paper");
            Console.WriteLine("3) Scissors");
        }
        static int Choice()
        {
            Console.Write("Make a selection: ");
            string answer = Console.ReadLine();

            while (answer != "1" && answer != "2" && answer != "3")
            {
                Console.Write("Make a selection: ");
                answer = Console.ReadLine();
            }

            int answerToInt = int.Parse(answer);
            return answerToInt;

        }
        static void Game()
        {
            int playerTotal = 0;
            int computerTotal = 0;

            while (playerTotal < 3 && computerTotal < 3)
            {
                Scoreboard(playerTotal, computerTotal);

                Random r = new Random();
                int computerPick = r.Next(1, 4);
                int playerPick = Choice();
                Console.WriteLine($"Player picked {Pick(playerPick)}");
                Console.WriteLine($"Computer picked {Pick(computerPick)}");

                if (playerPick == 1 && computerPick == 2 || playerPick == 2 && computerPick == 3 || playerPick == 3 && computerPick == 1)
                {
                    Console.WriteLine("Round Computer");
                    computerTotal++;
                }
                else if (playerPick == 2 && computerPick == 1 || playerPick == 3 && computerPick == 2 || playerPick == 1 && computerPick == 3)
                {
                    Console.WriteLine("Round Player");
                    playerTotal++;
                }
            }

            if (playerTotal == 3)
            {
                Console.WriteLine("YOU WIN");
            }
            else
            {
                Console.WriteLine("YOU LOSE");
            }
        }
        static string Pick(int choice)
        {
            if (choice == 1)
            {
                return "Rock";
            }
            else if (choice == 2)
            {
                return "Paper";
            }
            else
            {
                return "Scissors";
            }
        }
    }
}
