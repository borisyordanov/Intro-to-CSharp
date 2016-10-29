using System;

class RealToBinaryConverter
{
    static void Main(string[] args)
    {
        string inputRealNumber = Console.ReadLine();
        long realNumber = long.Parse(inputRealNumber);

        // If given number is negative
        if (realNumber < 0)
        {
            realNumber = realNumber ^ long.MinValue;
        }

        // Convert integer number to binary
        string binaryRepresentation = null;
        do
        {
            byte remainder = (byte)(realNumber % 2);
            binaryRepresentation = remainder + binaryRepresentation;
            realNumber /= 2;
        } while (realNumber != 0);
        Console.WriteLine(binaryRepresentation);
    }
}
