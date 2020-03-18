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
            Console.WriteLine($"What is {name}'s name?");
            this.name = Console.ReadLine();
            
        }
        //member methods       
        public override void ChooseAGesture()
        {
            Console.WriteLine($"{name}, Choose a gesture to throw");
            int gestureChoice = Convert.ToInt32(Console.ReadLine());
            if (Enumerable.Range(1, gestures.Count).Contains(gestureChoice))
            {
                Console.WriteLine($"{name} threw {gestures[gestureChoice - 1]}\n");
                gesture = gestures[gestureChoice - 1];
            }
            else
            {
                Console.WriteLine("Please choose from list of gestures");
                ChooseAGesture();
            } 
        }
            
        
        
    }
}
