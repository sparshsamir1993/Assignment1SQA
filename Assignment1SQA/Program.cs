using System;

namespace Assignment1SQA
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
            Triangle tri1 = new Triangle();
            
            string choice = string.Empty;
            int choiceNum;
            int[] sides = new int[3];
            Console.WriteLine("Enter your choice \n 1.Enter triangle sides \n 2. Exit");
            choice = Console.ReadLine();
            choice = tri1.checkUserChoice(choice);
            choiceNum = int.Parse(choice);
            
            if(choiceNum == 1)
            {
                sides = tri1.getSides();
                string message = TriangleSolver.Analyse(sides);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Have good day!");
            }

            
		}
	}
}
