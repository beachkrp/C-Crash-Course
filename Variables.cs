using System;

namespace Variables
{
	class Program
	{
		static void Main(String[] args)
		{
			//define some variables
			int firstNumber = 2;
			int secondNumber = 5;
			//declare and unspecified variable
			var subtraction = 7;

			//variable to hold the answer
			
			string prompt = ". Press Enter when Ready";

			//Output
			Console.WriteLine("Think of a number between 1 and 10" + prompt);
			// user input
			Console.ReadKey();

			//Output 
			Console.WriteLine("Multiply your number by " + firstNumber +prompt);
			//User input
			Console.ReadKey();

			//output
			Console.WriteLine("Now multiply the result by " + secondNumber + prompt);
			//User Input
			Console.ReadKey();

			//Output
			Console.WriteLine("Divide the Result by the number you originally thought of" + prompt);
			//User Input
			Console.ReadKey();

			//Output
			Console.WriteLine("Now Subtract" + subtraction + prompt);
			//User input
			Console.ReadKey();

			//Answer 
			Console.WriteLine("The answer is " + (firstNumber * secondNumber - subtraction));

		}
	}
}
