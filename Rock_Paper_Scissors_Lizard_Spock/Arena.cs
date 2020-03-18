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
        int pointsToWin;

        //constructor
        public Arena()
        {
            
        }
        //member methods
        public void PlayRPSLS()//Game sequence:
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            GetNumberOfPlayers();
            CreatePlayers(numberOfPlayers);
            DetermineLengthOfGame();
            DisplayRules();
            while (CheckForGameOver() == false)
            {
                PlayRoundOfRPSLS();
                DisplayScoreBoard();
            }
            DisplayWinner();
            PlayAnotherGame();            
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
            string stringOfNumberOfPlayers = Console.ReadLine();
            if (stringOfNumberOfPlayers != "1" && stringOfNumberOfPlayers != "2")
            {
                Console.WriteLine("That is not an appropriate number of players\n");
                GetNumberOfPlayers();
            }
            else
            {
                numberOfPlayers = Convert.ToInt32(stringOfNumberOfPlayers);
            }
        }
        public void CreatePlayers(int numberOfPlayers) //will instantiate either 2 humans or a human and a computer at game start
        {
            this.numberOfPlayers = numberOfPlayers;
            switch (numberOfPlayers)
            {
                case 1:
                    playerOne = new Human("Player One");
                    playerTwo = new AI();
                    Console.WriteLine($"{playerOne.name} vs {playerTwo.name}\n");
                    break;
                case 2:
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    Console.WriteLine($"{playerOne.name} vs {playerTwo.name}\n");
                    break;
                default:
                    Console.WriteLine("please enter 1 or 2");
                    numberOfPlayers = Convert.ToInt32(Console.ReadLine());
                    CreatePlayers(numberOfPlayers);
                    break;
            }
        }
        public void DetermineLengthOfGame()
        {
            Console.WriteLine("How many points would you like to play to?");
            int userInput = Convert.ToInt32(Console.ReadLine());
            if(userInput > 1 && userInput < 100)
            {
                Console.WriteLine($"Alright, let's play to {userInput} points\n");
                pointsToWin = userInput;
            }
            else if (userInput >= 100)
            {
                Console.WriteLine("Come on, that game would take FOREVER\n");
                DetermineLengthOfGame();
            }
            else
            {
                Console.WriteLine("Please choose an appropriate number of rounds\n");
                DetermineLengthOfGame();
            }
        }
        public void DisplayScoreBoard()
        {
            Console.WriteLine($"----------------------------\n" +
                $"SCORE BOARD \n{playerOne.name}: {playerOne.score} \n{playerTwo.name}: {playerTwo.score}\n" +
                $"----------------------------\n");
        }
        public void DetermineRoundWinner()
        {
            string playerOneGesture = playerOne.gesture;
            string playerTwoGesture= playerTwo.gesture;
            
            if(playerOneGesture == "Rock")
            {
                if (playerTwoGesture == "Scissors" || playerTwoGesture == "Lizard")
                {
                    Console.WriteLine($"{playerOne.name} wins the round\n");
                    playerOne.score++;
                }
                else if (playerTwoGesture == "Paper" || playerTwoGesture == "Spock")
                {
                    Console.WriteLine($"{playerTwo.name} wins the round\n");
                    playerTwo.score++;
                }
                else
                {
                    Console.WriteLine("It's a tie!\n");
                }
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
                else
                {
                    Console.WriteLine("It's a tie!");
                }
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
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                
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
                else
                {
                    Console.WriteLine("It's a tie!");
                }
                
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
                else 
                { 
                    Console.WriteLine("It's a tie!"); 
                }

            }
            
        }
        public bool CheckForGameOver()
        {
            if(playerOne.score == pointsToWin || playerTwo.score == pointsToWin)
            {
                Console.WriteLine("Game Over!");
                return true;
            }
            return false;            
        }

        public void DisplayWinner()
        {
            if (playerOne.score == pointsToWin)
            {
                Console.WriteLine($"{playerOne.name} wins!\n");
            }
            else if(playerTwo.score == pointsToWin)
            {
                Console.WriteLine($"{playerTwo.name} wins!\n");
            }
        }

        public void PlayAnotherGame()
        {
            Console.WriteLine("Would you like to play again? \nEnter 1 for yes \nEnter 2 for no");
            string playAgainToken = Console.ReadLine();
            switch (playAgainToken)
            {
                case "1":
                    Console.WriteLine("Alright! Let's play another round\n");
                    PlayRPSLS();
                    break;
                case "2":
                    Console.WriteLine("OK, Thanks for playing! Good-Bye");
                    Console.ReadLine();
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Please enter 1 or 2");
                    PlayAnotherGame();
                    break;
            }

        }
        public void DisplayRules()
        {
            Console.WriteLine("Here are the rules: \n\n" +
                "Rock crushes Scissors\n" +
                "Scissors cuts Paper\n" +
                "Paper covers Rock\n" +
                "Rock crushes Lizard\n" +
                "Lizard poisons Spock\n" +
                "Spock smashes Scissors\n" +
                "Scissors decapitates Lizard\n" +
                "Lizard eats Paper\n" +
                "Paper disproves Spock\n" +
                "Spock vaporizes Rock\n");
        }

        



    }
}
