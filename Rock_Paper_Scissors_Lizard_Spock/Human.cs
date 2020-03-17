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
        public override string ThrowAGesture()
        {
            Console.WriteLine("Choose a gesture to throw");
            int i = 0;
            foreach (Gesture gesture in gestures)
            {
                Console.WriteLine($"{i+1} {gesture.gestureName}");
                i++;
            }
            int gestureChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} threw {gestures[gestureChoice-1].gestureName}");
            return gestures[gestureChoice - 1].gestureName;
        }
    }
}
