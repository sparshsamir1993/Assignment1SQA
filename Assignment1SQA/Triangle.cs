using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1SQA
{
    public class Triangle
    {
        public int[] sides = new int[3];
        public int[] getSides()
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Enter length of side " + (i+1));
                string side = Console.ReadLine();
                int currSide;
                while(!int.TryParse(side, out currSide))
                {
                    Console.WriteLine("Please enter a valid value");
                    side = Console.ReadLine();
                }
                sides[i] = currSide;
            }
            return sides;
        }

        public string checkUserChoice(string choice)
        {
            
            while (!choice.Equals("1") && !choice.Equals("2"))
            {
                Console.WriteLine("Enter a valid value");
                choice = Console.ReadLine();
            }
            return choice;
        }
    }
}
