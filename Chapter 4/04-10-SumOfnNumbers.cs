using System;

namespace SumOfnNumbers
{
	class SumOfnNumbers
	{
		static void Main(string[] args)
		{
			long sum = 0;
			uint n = uint.Parse(Console.ReadLine());
			for (int i = 0; i < n; i++)
			{
				int currentNumber = int.Parse(Console.ReadLine());
				sum += currentNumber;
			}
			Console.WriteLine(sum);
		}
	}
}