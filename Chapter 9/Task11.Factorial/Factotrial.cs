using System;
using System.Numerics;

class Factorial
{
    static void Main(string[] args)
    {
        string inputFactorialN = Console.ReadLine();
        uint factorialN = uint.Parse(inputFactorialN);

        BigInteger[] factorialResults = CalculationOfFactorial(factorialN);
        PrintAllResults(factorialResults);
    }

    private static BigInteger[] CalculationOfFactorial(uint countOfLoops)
    {
        BigInteger[] factorialCalculations = new BigInteger[countOfLoops];
        BigInteger factorial = 1;

        for (int i = 1; i <= countOfLoops; i++)
        {
            factorialCalculations[i - 1] = factorial;

            factorial = factorial * i;
        }

        return factorialCalculations;
    }

    private static void PrintAllResults(BigInteger[] factorialResult)
    {
        for (int i = 0; i < factorialResult.Length; i++)
        {
            Console.WriteLine(factorialResult[i]);
        }
    }
}
