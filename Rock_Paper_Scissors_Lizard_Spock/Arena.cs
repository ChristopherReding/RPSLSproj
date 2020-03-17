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

        //constructor
        public Arena()
        {
            
        }
        //member methods
        public void PlayRPSLS()
        {
            SelectPlayers();
            playerOne.ThrowAGesture();
        }
        public void SelectPlayers() //will instantiate either 2 humans or a human and a computer at game start
        {
            Console.WriteLine("Please enter: \n1 for single player  \n2 for multiplayer");
            string numberOfPlayers = Console.ReadLine();
            switch (numberOfPlayers)
            {
                case "1":
                    playerOne = new Human("Player One");
                    playerTwo = new Human("Player Two");
                    break;
                case "2":
                    playerOne = new Human("Player One");
                    playerTwo = new AI();
                    break;
                default:
                    Console.WriteLine("please enter 1 or 2");
                    SelectPlayers();
                    break;
            }

        }
    }
}
