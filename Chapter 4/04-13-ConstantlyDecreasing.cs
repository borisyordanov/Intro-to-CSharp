using System;
using System.Linq;


class SumCalculate
{
    static void Main(string[] args)
    {
        decimal oldSum = 1M;
        decimal newSum = 1M;
        decimal denominator = 2M;
        decimal absSumDifference;

        do
        {
            oldSum = newSum;
            newSum += ((decimal)1 / denominator);

            denominator++;
            absSumDifference = Math.Abs(newSum - oldSum);

        } while (Decimal.Compare(absSumDifference, 0.001M) > 0);

        Console.WriteLine("The sum is {0:F3}", newSum);
    }
}