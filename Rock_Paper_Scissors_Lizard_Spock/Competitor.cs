using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public abstract class Competitor
    {
        //member variables
        public string name;
        public int score;
        public Gesture[] GestureChoices;
        //constructor
        public Competitor()
        {
            score = 0;
            GestureChoices = new Gesture[]
            {
                new Gesture("Rock"),//index 0
                new Gesture("Paper"),//1
                new Gesture("Scissors"),//2
                new Gesture("Lizard"),//3
                new Gesture("Spock"),//4
            };
        }
        //member methods
        public virtual void ThrowAGesture()
        {
        }
    }
}
