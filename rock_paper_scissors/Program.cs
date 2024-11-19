namespace rock_paper_scissors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int drawNum = 0;
            int playerWins = 0;
            int cpuWins = 0;
            string[] rps = new string[] { "ROCK", "PAPER", "SCISSORS" };

            string userChoice = "";
            string pcChoice = "";
            string playAgain = "Y";

            while (playAgain == "Y")
            {
                Game();

                Console.WriteLine("Your choice: " + userChoice);
                Console.WriteLine("CPU choice: " + pcChoice);

                if (CheckPlayerVictory())
                {
                    Console.WriteLine("\nPlayer wins!");
                    playerWins++;
                }
                else if (CheckCpuVictory())
                {
                    Console.WriteLine("\nCPU wins...");
                    cpuWins++;
                }
                else if (!rps.Contains(userChoice))
                {
                    Console.WriteLine("\nInsert a valid input!");
                }
                else
                {
                    Console.WriteLine("\nTie.");
                    drawNum++;
                }

                Score();
                PlayAgain();
            }

            void Game()
            {
                Console.Clear();
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("                    ROCK PAPER SCISSORS GAME");
                Console.WriteLine("--------------------------------------------------------------------\n\n");
                Console.Write("Rock, paper or scissors?: ");
                userChoice = Console.ReadLine().ToUpper();

                Random rand1 = new Random();
                int randomNum = rand1.Next(rps.Length);
                pcChoice = rps[randomNum];
            }

            void PlayAgain()
            {
                Console.WriteLine("Y to play again, or any other key to quit.");
                playAgain = Console.ReadLine().ToUpper();
            }

            void Score()
            {
                Console.WriteLine("\n\n--------------------------------------------------------------------");
                Console.WriteLine("                               SCORE");
                Console.WriteLine("--------------------------------------------------------------------\n\n");
                Console.WriteLine($"PLAYER WINS: {playerWins}" + $"\nCPU WINS: {cpuWins}" + $"\nDRAWS: {drawNum}");
                Console.WriteLine("\n\n--------------------------------------------------------------------");
            }

            bool CheckPlayerVictory()
            {
                bool RockWin = userChoice == rps[0] && pcChoice == rps[2];
                bool ScissorsWin = userChoice == rps[2] && pcChoice == rps[1];
                bool PaperWin = userChoice == rps[1] && pcChoice == rps[0];

                return RockWin || ScissorsWin || PaperWin;
            }

            bool CheckCpuVictory()
            {
                bool RockWin = pcChoice == rps[0] && userChoice == rps[2];
                bool ScissorsWin = pcChoice == rps[2] && userChoice == rps[1];
                bool PaperWin = pcChoice == rps[1] && userChoice == rps[0];

                return RockWin || ScissorsWin || PaperWin;
            }
        }
    }
}
