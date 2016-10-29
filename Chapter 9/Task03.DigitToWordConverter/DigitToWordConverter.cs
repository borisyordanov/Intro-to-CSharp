using System;

class DigitToWordConverter
{
    static void Main(string[] args)
    {
        int number = int.Parse(Console.ReadLine());
        string digitInWord = ReturnLastNumberDigitAsWord(number);

        Console.WriteLine(digitInWord);
    }

    static string ReturnLastNumberDigitAsWord(int number)
    {
        sbyte lastDigit = (sbyte)((number) % 10);

        if (lastDigit < 0)
        {
            lastDigit = Math.Abs(lastDigit);
        }

        string digitAsWord = String.Empty;

        switch (lastDigit)
        {
            case 0:
                digitAsWord = "zero";
                break;
            case 1:
                digitAsWord = "one";
                break;
            case 2:
                digitAsWord = "two";
                break;
            case 3:
                digitAsWord = "three";
                break;
            case 4:
                digitAsWord = "four";
                break;
            case 5:
                digitAsWord = "five";
                break;
            case 6:
                digitAsWord = "six";
                break;
            case 7:
                digitAsWord = "seven";
                break;
            case 8:
                digitAsWord = "eight";
                break;
            case 9:
                digitAsWord = "nine";
                break;
            default:
                break;
        }

        return digitAsWord;
    }
}
