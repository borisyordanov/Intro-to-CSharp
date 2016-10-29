using System;

class HornerConverter
{
    static void Main(string[] args)
    {
        string inputBinaryNumber = Console.ReadLine();
        const byte baseNumber = 2;
        byte currentDigit = byte.Parse(inputBinaryNumber[0].ToString());

        long decimalNumber = currentDigit;
        for (int i = 1; i < inputBinaryNumber.Length; i++)
        {
            decimalNumber *= baseNumber;
            currentDigit = byte.Parse(inputBinaryNumber[i].ToString());
            decimalNumber += currentDigit;
        }
        Console.WriteLine(decimalNumber);
    }
}
