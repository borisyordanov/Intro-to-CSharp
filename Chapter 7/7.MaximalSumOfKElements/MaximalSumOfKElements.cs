using System;

class MaximalSumOfKElements
{
    static void Main(string[] args)
    {
        string enterN = Console.ReadLine();
        int arrayLength = int.Parse(enterN);

        string enterK = Console.ReadLine();
        int lengthOfSequence = int.Parse(enterK);

        int[] arrayOfNumbers = new int[arrayLength];
        string enterDigit;
        for (int count = 0; count < arrayLength; count++)
        {
            enterDigit = Console.ReadLine();
            arrayOfNumbers[count] = int.Parse(enterDigit);
        }

        //calculate sums of sequences
        int maxCountSum = arrayLength - lengthOfSequence + 1;
        long[] sums = new long[maxCountSum];
        for (int index = 0; index < maxCountSum; index++)
        {
            for (int count = 0; count < lengthOfSequence; count++)
            {
                sums[index] = sums[index] + arrayOfNumbers[index + count];
            }
        }

        //find max sum
        int maxSumIndex = 0;
        for (int index = 1; index < sums.GetLength(0); index++)
        {
            if (sums[maxSumIndex] < sums[index])
            {
                maxSumIndex = index;
            }
        }

        for (int index = 0; index < lengthOfSequence; index++)
        {
            Console.Write("{0} ",arrayOfNumbers[index + maxSumIndex]);
        }
    }
}

