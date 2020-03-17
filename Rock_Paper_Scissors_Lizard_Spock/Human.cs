using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class Human : Competitor
    {
        //member variables

        //constructor
        public Human(string name)
        {
            this.name = name;
            
        }
        //member methods
        public override void ThrowAGesture()
        {
            Console.WriteLine("Choose a gesture to throw");
            int i = 1;
            foreach (Gesture gesture in GestureChoices)
            {
                Console.WriteLine($"{i} {gesture.gestureName}");
                i++;
            }


        }
    }
}
