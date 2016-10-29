using System;


namespace TwoPositiveIntegerNumbers
{
    class MultiplesOfFive
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int count = 0;

            for (int i = firstNumber; i <= secondNumber; i++)
            {
                if (i % 5 == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }
    }
}
