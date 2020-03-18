using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Arena
    {
        //member variables
        Competitor playerOne;
        Competitor playerTwo;
        int numberOfPlayers;
        //constructor
        public Arena()
        {
            
        }
        //member methods
        public void PlayRPSLS()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            //display rules
            GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            //playrounds till game is over
            //display winner

        }
        public void PlayRoundOfRPSLS()
        {
            playerOne.DisplayGestureChoices();
            playerOne.ChooseAGesture();
            playerTwo.ChooseAGesture();
            DetermineRoundWinner();
        }
        public void GetNumberOfPlayers()
        {
            Console.WriteLine("Please enter number of players");
            numberOfPlayers = Convert.ToInt32(Console.ReadLine());            
        }
        public void CreatePlayers(int numberOfPlayers) //will instantiate either 2 humans or a human and a computer at game start
        {
            this.numberOfPlayers = numberOfPlayers;
            switch (numberOfPlayers)
            {
                case 1:
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    break;
                case 2:
                    playerOne = new Human("Player One");
                    playerTwo = new AI();
                    break;
                default:
                    Console.WriteLine("please enter 1 or 2");
                    numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                    CreatePlayers(numberOfPlayers);
                    break;
            }
        }
        
        public void DisplayScoreBoard()
        {
            Console.WriteLine($"SCORE BOARD \n{playerOne.name}: {playerOne.score} \n{playerTwo.name}: {playerTwo.score}");
        }
        public void DetermineRoundWinner(string playerOneGesture, string playerTwoGesture)
        {
            this.playerOne.gesture = playerOneGesture;
            this.playerTwo.gesture = playerTwoGesture;
            
            if(playerOneGesture == "Rock")
            {
                if(playerTwoGesture == "Scissors" || playerTwoGesture == "Lizard")
                {
                    Console.WriteLine($"{playerOne.name} wins the round");
                    playerOne.score++;
                }
                else if(playerTwoGesture == "Paper" || playerTwoGesture == "Spock")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    playerTwo.score++;
                }
                Console.WriteLine("It's a tie!");
            }
            else if (playerOneGesture == "Paper")
            {
                if (playerTwoGesture == "Rock" || playerTwoGesture == "Spock")
                {
                    Console.WriteLine($"{playerOne.name} wins the round");
                    playerOne.score++;
                }
                else if (playerTwoGesture == "Scissors" || playerTwoGesture == "Lizard")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    playerTwo.score++;
                }
                Console.WriteLine("It's a tie!");
            }
            else if(playerOneGesture == "Scissors")
            {
                if (playerTwoGesture == "Paper" || playerTwoGesture == "Lizard")
                {
                    Console.WriteLine($"{playerOne.name} wins the round");
                    playerOne.score++;
                }
                else if (playerTwoGesture == "Rock" || playerTwoGesture == "Spock")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    playerTwo.score++;
                }
                Console.WriteLine("It's a tie!");
            }
            else if(playerOneGesture == "Lizard")
            {
                if (playerTwoGesture == "Spock" || playerTwoGesture == "Paper")
                {
                    Console.WriteLine($"{playerOne.name} wins the round");
                    playerOne.score++;
                }
                else if (playerTwoGesture == "Rock" || playerTwoGesture == "Scissors")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    playerTwo.score++;
                }
                Console.WriteLine("It's a tie!");
            }
            else if(playerOneGesture == "Spock")
            {
                if (playerTwoGesture == "Scissors" || playerTwoGesture == "Rock")
                {
                    Console.WriteLine($"{playerOne.name} wins the round");
                    playerOne.score++;
                }
                else if (playerTwoGesture == "Lizard" || playerTwoGesture == "Paper")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round");
                    playerTwo.score++;
                }
                Console.WriteLine("It's a tie!");
            }
            
        }
        public bool CheckForGameOver()
        {
            if(playerOne.score == 2 || playerTwo.score == 2)
            {
                Console.WriteLine("Game Over!");
                return true;
            }
            return false;            
        }





    }
}
