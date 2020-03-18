using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    class Program
    {
        static void Main(string[] args)
        {
            Arena showdownRPSLS = new Arena();
            showdownRPSLS.PlayRPSLS();
        }
    }
    //Steps of game
    //1. display the rules of game -- game class
    //2. how many players? -- PvC or PvP -- game
    //3. Set name of the players -- player class
    //4. choose a gesture -- player
    //5. compare gestures - game
    //6. etermine round winner  --game
    //7. increment score of round winnder --game
    //8. check for game winner -- best 2 of 3 -- game
    //8a. if winnder is true, ask to play again (step 1) 
    //8b. if game winner is not true, then repeat step 4
}
