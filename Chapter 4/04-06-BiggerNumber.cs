using System;

namespace BiggerNumber
{
	class BiggerNumber
	{
		static void Main(string[] args)
		{
			int first = int.Parse(Console.ReadLine());
			int second = int.Parse(Console.ReadLine());

			int bigger = (first + second + Math.Abs(first - second)) / 2;
			Console.WriteLine(bigger);
		}
	}
}
