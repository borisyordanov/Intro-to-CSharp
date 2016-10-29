using System;

class SumOfNumbers
{
	static void Main()
	{
		int currentNum = new int();
		decimal sum = new int();
		int numCount = new int();
		bool loop = true;

		while (loop)
		{
			if (numCount < 5)
			{
				if (int.TryParse(Console.ReadLine(), out currentNum))
				{
					sum += currentNum;
					numCount++;
				}
			}
			else
			{
				loop = false;
			}
		}

		Console.WriteLine(sum);
	}
}
