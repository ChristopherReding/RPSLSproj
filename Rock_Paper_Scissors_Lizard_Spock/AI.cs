﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Lizard_Spock
{
    public class AI : Competitor
    {
        //member variables

        //constructor
        public AI()
        {
            name = "Simon";
        }
        //member methods
        public override string ThrowAGesture()
        {
            Random randomNumber = new Random();
            int gestureChoice = randomNumber.Next(4);
            Console.WriteLine($"{name} threw {gestures[gestureChoice].gestureName}");
            return gestures[gestureChoice].gestureName;
            
        }

    }
}
