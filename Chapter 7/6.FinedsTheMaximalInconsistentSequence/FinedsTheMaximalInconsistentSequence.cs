using System;

class FinedsTheMaximalInconsistentSequence
{
    static void Main(string[] args)
    {
        string enterLength = Console.ReadLine();
        int arrayLength = int.Parse(enterLength);
        int[] arrayOfNumbers = new int[arrayLength];
        //enter array
        string enterDigit;
        for (int count = 0; count < arrayLength; count++)
        {
            enterDigit = Console.ReadLine();
            arrayOfNumbers[count] = int.Parse(enterDigit);
        }
    }
}

