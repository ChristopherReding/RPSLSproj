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
        public string gesture;
        public List<string> gestures = new List<string>();
        //constructor
        public Competitor()
        {
            score = 0;
            
            gestures.Add("Rock");//0
            gestures.Add("Paper");//1
            gestures.Add("Scissors");//2
            gestures.Add("Lizard");//3
            gestures.Add("Spock");//4
        }

        //member methods
        public abstract void ChooseAGesture();
        public void DisplayGestureChoices()
        {
            int i = 0;
            foreach (string gesture in gestures)
            {
                Console.WriteLine($"{i + 1} {gesture}");
                i++;
            }
        }

    }
}

