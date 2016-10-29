using System;

class FindsTheMaximalIncreasingSequence
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

        //find max increasing sequence
        int maxCount = 0;
        int startIndex = 0;
        for (int count = 0; count < arrayLength; count++)
        {
            int currentCount = 0;
            for (int minCount = count; minCount < arrayLength - 1; minCount++)
            {
                if (arrayOfNumbers[minCount] < arrayOfNumbers[minCount + 1])
                {
                    currentCount++;
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        startIndex = count;
                    }
                }
                else
                {
                    break;
                }
            }
        }

        for (int count = 0; count <= maxCount; count++)
        {
            Console.Write("{0} ", arrayOfNumbers[startIndex + count]);
        }
        Console.WriteLine();
    }
}

