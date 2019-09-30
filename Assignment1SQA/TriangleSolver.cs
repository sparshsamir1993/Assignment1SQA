using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment1SQA
{
    public static class TriangleSolver
    {
        public static string Analyse(float[] sides)
        {
            if( (sides[0] + sides[1] >= sides[2]) && 
                (sides[1] + sides[2] >= sides[0]) && 
                (sides[2] + sides[0] > sides[1]))
            {
                if(sides[0] == sides[1] && sides[1] == sides[2] && sides[2] == sides[0])
                {
                    return "Equilateral";
                }
                else if(sides[0] == sides[1] || sides[1] == sides[2] || sides[2] == sides[0])
                {
                    return "isosceles";
                }
                else
                {
                    return "Scalene";
                }
            }
            else
            {
                return "invalid";
            }
            
        }
    }
}
