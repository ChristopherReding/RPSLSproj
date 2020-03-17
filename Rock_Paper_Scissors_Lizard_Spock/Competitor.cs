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
        public List<Gesture> gestures = new List<Gesture>();
        //constructor
        public Competitor()
        {
            score = 0;
            Gesture rock = new Gesture("Rock");
            Gesture paper = new Gesture("Paper");
            Gesture scissors = new Gesture("Scissors");
            Gesture lizard = new Gesture("Lizard");
            Gesture spock = new Gesture("Spock");
            gestures.Add(rock);//0
            gestures.Add(paper);//1
            gestures.Add(scissors);//2
            gestures.Add(lizard);//3
            gestures.Add(spock);//4
        }
           
        //member methods
        public virtual string ThrowAGesture()
        {
        }
    }
}

