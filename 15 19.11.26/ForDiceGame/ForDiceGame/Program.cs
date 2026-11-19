using System.Data;
using System.Text;

namespace ForDiceGame
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, World!");

            Random random = new Random();

            int playerScore = 0;
            int computerScore = 0;

            for (int round = 1; round <= 500; round++)
            {
                Console.WriteLine($"Voor {round}. Vajuta Enter, et täringut veeretada");
                Console.ReadLine();

                int playerRoll = random.Next(1, 7);
                int computerRoll = random.Next(1, 7);

                Console.WriteLine($"sinu number: {playerRoll}");
                Console.WriteLine($"vaenlase number: {computerRoll}");
                if (playerRoll > computerRoll)
                {
                    Console.WriteLine("Sina võitsid vooru!");
                    playerScore++;
                }
                else if (computerRoll > playerRoll)
                {
                    Console.WriteLine("arvuti võitis vooru!");
                    computerScore++;
                }
                else
                {
                    Console.WriteLine("voor jäi viiki");
                }
            }
            Console.WriteLine("mäng läbi");

            if (playerScore > computerScore)
            {
                Console.WriteLine("sina võitsid kogu mängu!");
            }
            else if (computerScore > playerScore)
            {
                Console.WriteLine("arvuti võitsid kogu mängu!");
            }
            else
            {
                Console.WriteLine("sull on viik!");
            }
        }
    }
}