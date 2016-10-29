using System;

class MaxNumberOfThree
{
    static void Main(string[] args)
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int thirdNumber = int.Parse(Console.ReadLine());

        int greatestNumber = GetMax(firstNumber, secondNumber);
        greatestNumber = GetMax(greatestNumber, thirdNumber);

        Console.WriteLine(greatestNumber);
    }

    /// <summary>
    /// Gets the greatest number.
    /// </summary>
    /// <param name="firstNumber">The first number.</param>
    /// <param name="secondNumber">The second number.</param>
    /// <returns></returns>
    static int GetMax(int firstNumber, int secondNumber)
    {
        int maxNumber = firstNumber;

        if (maxNumber < secondNumber)
        {
            maxNumber = secondNumber;
        }

        return maxNumber;
    }
}
