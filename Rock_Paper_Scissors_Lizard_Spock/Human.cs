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
        public override void ChooseAGesture()
        {
            Console.WriteLine("Choose a gesture to throw");            
            int gestureChoice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} threw {gestures[gestureChoice-1]}");
            gesture = gestures[gestureChoice - 1];
        }
        
    }
}
