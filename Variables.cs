using System;

namespace Variables
{
	class Program
	{
		static void Main(String[] args)
		{	
			//Introducing a random element
			Random randomNumber = new Random();

			//define some variables
			int firstNumber = randomNumber.Next(2,10);
			int secondNumber = randomNumber.Next(2,10);
			//declare and unspecified variable
			var subtraction = randomNumber.Next(2,10);

			//inialize the variable to hold the answer
			int answer = firstNumber * secondNumber - subtraction;
			
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
			Console.WriteLine("Now Subtract " + subtraction + prompt);
			//User input
			Console.ReadKey();

			//Answer 
			
			Console.WriteLine("The answer is " + answer);

		}
	}
}
