using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
                 
            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();

            Start:
            int userScore = 0;
            int cpuScore = 0;
            string userChoise;
            int cpuChoise;
            bool gameOver = false;

            while (!gameOver)
            {

            Random rnd = new Random();
            Console.WriteLine($"Hello {name}, please choose stone, paper or scissors");
            cpuChoise = rnd.Next(1, 4);
            userChoise = Console.ReadLine();
            
                switch (cpuChoise)
                {
                    case 1:
                        Console.WriteLine("stone");
                    if (userChoise.ToLower() == "stone")
                    {
                        continue;
                    }
                    else if (userChoise.ToLower() == "paper")
                    {
                        userScore++;
                    }
                    else
                    {
                        cpuScore++;
                    }
                    break;

                    case 2:
                        Console.WriteLine("paper");
                    if (userChoise.ToLower() == "stone")
                    {
                        cpuScore++;
                    }
                    else if (userChoise.ToLower() == "paper")
                    {
                        continue;
                    }
                    else
                    {
                        userScore++;
                    }
                    break;

                    case 3:
                        Console.WriteLine("scissors");
                    if (userChoise.ToLower() == "scissors")
                    {
                        continue;
                    }
                    else if (userChoise.ToLower() == "stone")
                    {
                        userScore++;
                    }
                    else
                    {
                        cpuScore++;
                    }
                    break;

                    default:
                        
                    break;

                }

                Console.WriteLine($"{name} got {userScore} points and CPU got {cpuScore} points.");

                if (userScore == 3)
                {
                    Console.WriteLine($"{name} won a game!");
                }
                else if (cpuScore==3)
                {
                    Console.WriteLine($"CPU won a game!");
                }
                else
                {
                    continue;
                }

                Console.WriteLine($"{name}, would you like to play again? Y/N");
                string answer = Console.ReadLine();

                if (answer.ToUpper() == "Y")
                    {
                        goto Start;
                    }

                else
                    {
                        Console.WriteLine ("Game over!");
                        gameOver =true;
                    }

            }
               
            Console.ReadLine();

            

        }
    }
}

