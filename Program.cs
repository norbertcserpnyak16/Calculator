using System;


namespace Szamologep
{
	class Program
	{

		static void Main(string[] args)
		{

			//változókkal való műveletek!
			Console.WriteLine("Enter a number!");
			double a = double.Parse(Console.ReadLine());
			Console.WriteLine("Enter another number!");
			double b = double.Parse(Console.ReadLine());
			double ab = Math.Round(a + b, 4);
			double ab2 = Math.Round(a - b, 4);
			double ab3 = Math.Round(a * b, 4);
			double ab4 = Math.Round(a / b, 4);

			//Változókkal való müveletek eredményének a kiiratása!
			Console.WriteLine($"This is the result of adding variables A and B: {ab}");
			Console.WriteLine($"This is the result of subtracting variables A and B: {ab2}");
			Console.WriteLine($"This is the result of multiplying variables A and B: {ab3}");
			Console.WriteLine($"Result of dividing variables A and B: {ab4}");
		}

		static bool Paros(int szam)
		{
			return szam % 2 == 0;
		}
		static bool Pozitiv(double number)
		{
			return number >= 0;
		}
	}
}


