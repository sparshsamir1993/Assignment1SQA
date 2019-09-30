using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1SQA
{
    class Triangle
    {
        public float[] sides = new float[3];
        public void getSides()
        {
            for(int i=0; i<3; i++)
            {
                Console.WriteLine("Enter length of side " + i);
                string side = Console.ReadLine();
                float currSide;
                while(!float.TryParse(side, out currSide))
                {
                    Console.WriteLine("Please enter a valid value");
                    side = Console.ReadLine();
                }
                sides[i] = currSide;
            }
        }
    }
}
