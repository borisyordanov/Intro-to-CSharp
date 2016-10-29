using System;

class NumberReverser
{
    static void Main(string[] args)
    {
        string inputNumber = Console.ReadLine();
        string reversedNumber = ReverseDigits(inputNumber);

        Console.WriteLine(reversedNumber);
    }

    private static string ReverseDigits(string inputNumber)
    {
        char[] reversedNumber = new char[inputNumber.Length];

        for (int i = 0; i < inputNumber.Length; i++)
        {
            reversedNumber[i] = inputNumber[inputNumber.Length - i - 1];
        }

        return new String(reversedNumber);
    }
}
