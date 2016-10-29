using System;

class FindsTheMaximalSequence
{
    static void Main(string[] args)
    {
        string enterLength = Console.ReadLine();
        int arrayLength = int.Parse(enterLength);
        int[] arrayOfNumbers = new int[arrayLength];
        string enterString;
        for (int count = 0; count < arrayLength; count++)
        {
            enterString = Console.ReadLine();
            arrayOfNumbers[count] = int.Parse(enterString);
        }
        int maxCount = 0;
        int value = 0;
        for (int count = 0; count < arrayLength; count++)
        {
            int currentCount = 0;
            for (int minCount = count; minCount < arrayLength; minCount++)
            {
                if (arrayOfNumbers[count] == arrayOfNumbers[minCount])
                {
                    currentCount++;
                    if (maxCount < currentCount)
                    {
                        maxCount = currentCount;
                        value = arrayOfNumbers[count];
                    }
                }
                else
                {
                    break;
                }
            }
        }            
        Console.WriteLine("Max length = {0} and value is {1}", maxCount, value);                        
    }
}

