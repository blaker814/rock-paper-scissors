﻿using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Scoreboard(0, 0);
            Round();
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
            int answer = int.Parse(Console.ReadLine());

            while (answer != 1 && answer != 2 && answer != 3)
            {
                answer = int.Parse(Console.ReadLine());
            }

            return answer;

        }
        static void Round()
        {
            int playerTotal = 0;
            int computerTotal = 0;

            while (playerTotal < 3 && computerTotal < 3)
            {
                Random r = new Random();
                int computerPick = r.Next(1, 4);
                int playerPick = Choice();
                Console.WriteLine(computerPick);

                if (playerPick == 1 && computerPick == 2 || playerPick == 2 && computerPick == 3 || playerPick == 3 && computerPick == 1)
                {
                    computerTotal++;
                }
                else if (playerPick == 2 && computerPick == 1 || playerPick == 3 && computerPick == 2 || playerPick == 1 && computerPick == 3)
                {
                    playerTotal++;
                }

                Scoreboard(playerTotal, computerTotal);

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
    }
}