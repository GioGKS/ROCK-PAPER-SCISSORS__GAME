using System;
namespace Small_Project
{
	public class GameClass
	{
		string playerChoose;
		string compChoose;
		int randomInt;
		bool playAgain = true;

        public GameClass()
        {

        }

		public void StartGame()
        {
			while(playAgain == true)
            {

				int playerScore = 0;
				int compScore = 0;

                while (playerScore < 3 && compScore < 3)
                {

                    Console.Write("Choose between ROCK, PAPER and SCISSORS:    ");
                    playerChoose = Console.ReadLine();
                    playerChoose = playerChoose.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            compChoose = "ROCK";
                            Console.WriteLine("Computer chose ROCK");
                            if (playerChoose == "ROCK")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerChoose == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (playerChoose == "SCISSORS")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            break;
                        case 2:
                            compChoose = "PAPER";
                            Console.WriteLine("Computer chose PAPER");
                            if (playerChoose == "PAPER")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerChoose == "ROCK")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            else if (playerChoose == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            break;
                        case 3:
                            compChoose = "SCISSORS";
                            Console.WriteLine("Computer chose SCISSORS");
                            if (playerChoose == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!\n\n");
                            }
                            else if (playerChoose == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!\n\n");
                                playerScore++;
                            }
                            else if (playerChoose == "PAPER")
                            {
                                Console.WriteLine("CPU WINS!!\n\n");
                                compScore++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid entry!");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", playerScore, compScore);
                }

                if (playerScore == 3)
                {
                    Console.WriteLine("Player WON!");
                }
                else if (compScore == 3)
                {
                    Console.WriteLine("CPU WON!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }
            }
        }
	}
}

