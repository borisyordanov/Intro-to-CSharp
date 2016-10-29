using System;

class BinaryToDecimalConverter
{
    static void Main(string[] args)
    {
        string binaryRepresentation = Console.ReadLine();

        long decimalRepresentation = 0;
        long multiplier = 1;
        for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
        {
            if (binaryRepresentation[i] == '1')
            {
                decimalRepresentation = decimalRepresentation + multiplier;
            }

            multiplier = multiplier * 2;
        }

        Console.WriteLine(decimalRepresentation);
    }
}
