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
        
           
            int userScore = 0;
            int cpuScore = 0;
            string userChoise;
            int cpuChoise;

            Console.WriteLine("Please, enter your name:");
            string name = Console.ReadLine();

            while (userScore < 3 && cpuScore < 3)
            {

            Random rnd = new Random();
            Console.WriteLine($"Hello {name}, please choose stone, paper or scissors");
            cpuChoise = rnd.Next(1, 4);
            userChoise = Console.ReadLine();
            
                switch (cpuChoise)
                {
                    case 1:
                        Console.WriteLine("stone");
                    if (userChoise== "stone")
                    {
                        continue;
                    }
                    else if (userChoise== "paper")
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
                    if (userChoise== "stone")
                    {
                        cpuScore++;
                    }
                    else if (userChoise == "paper")
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
                    if (userChoise == "scissors")
                    {
                        continue;
                    }
                    else if (userChoise == "stone")
                    {
                        userScore++;
                    }
                    else
                    {
                        cpuScore++;
                    }
                    break;

                    default:
                        Console.WriteLine($"Invalid entry");
                    break;

                }

            Console.WriteLine($"{name} got {userScore} points and CPU got {cpuScore} points.");

                if (userScore == 3)
                {
                    Console.WriteLine($"{name} won a game!");
                }
                else if (cpuScore == 3)
                {
                    Console.WriteLine($"CPU won a game!");
                }
                else
                {
                    
                }

                    






            }
               
            
            Console.ReadLine();


















           




            

        }
    }
}

