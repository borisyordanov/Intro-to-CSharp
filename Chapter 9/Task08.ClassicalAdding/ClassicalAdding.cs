using System;
using System.Text;

class ClassicAdding
{
    static void Main(string[] args)
    {
        string firstNumber = Console.ReadLine();
        string secondNumber = Console.ReadLine();

        string sum = ClasicalSum(firstNumber, secondNumber);
        Console.WriteLine(sum);
    }

    /// <summary>
    /// Clasical adding of two numbers.
    /// Suming every digit of two numers one by one with reminder
    /// from last to first digit
    /// </summary>
    /// <param name="firstOperand">First operand.</param>
    /// <param name="second">Second operand.</param>
    /// <returns>The result</returns>
    public static string ClasicalSum(string firstOperand, string secondOperand)
    {
        //reversing the strings to start adding from most left digit
        string firstNumberReversed = Reverse(firstOperand);
        string secondNumberReversed = Reverse(secondOperand);

        int maxLenght = firstNumberReversed.Length;
        if (secondNumberReversed.Length > maxLenght)
        {
            maxLenght = secondNumberReversed.Length;
        }

        StringBuilder sum = new StringBuilder();

        int remainder = 0; // the value if currentSum is bigger then 9 (number of possible digits)
        for (int i = 0; i < maxLenght; i++)
        {
            int currentSum = remainder;
            if (i < firstNumberReversed.Length)
            {
                string currentDigitFirstNumber = firstNumberReversed[i].ToString();
                int digitFirstNumber = int.Parse(currentDigitFirstNumber);
                currentSum += digitFirstNumber;
            }
            if (i < secondNumberReversed.Length)
            {
                string currentDigitSecondNumber = secondNumberReversed[i].ToString();
                int digitSecondNumber = int.Parse(currentDigitSecondNumber);
                currentSum += digitSecondNumber;
            }

            remainder = currentSum / 10;
            if (remainder > 0)
            {
                sum.Append(currentSum % 10);
            }
            else
            {
                sum.Append(currentSum);
            }
        }

        if (remainder > 0)
        {
            sum.Append(remainder);
        }
        string finalSum = Reverse(sum.ToString());
        return finalSum;
    }

    /// <summary>
    /// Reverses the specified input string.
    /// </summary>
    /// <param name="input">The string for reversing.</param>
    /// <returns>Reversed string</returns>
    public static string Reverse(string input)
    {
        StringBuilder reversed = new StringBuilder();
        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed.Append(input[i]);
        }

        return reversed.ToString();
    }
}
