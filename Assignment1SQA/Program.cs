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
            Console.WriteLine("Enter your choice \n 1.Enter triangle sides \n 2. Exit");
            choice = Console.ReadLine();
            while(!choice.Equals("1") && !choice.Equals("2"))
            {
                Console.WriteLine("Enter a valid value");
                choice = Console.ReadLine();
            }
            choiceNum = int.Parse(choice);
            if(choiceNum == 1)
            {
                tri1.getSides();
                string message = TriangleSolver.Analyse(tri1.sides);
                Console.WriteLine(message);
            }
            else
            {
                Console.WriteLine("Have good day!");
            }

            
		}
	}
}
