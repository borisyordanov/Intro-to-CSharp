using System;

class RepetitionsOfElement
{
    static void Main(string[] args)
    {
        CountRepetitionsOfElementInSequenceProcess();
    }

    private static void CountRepetitionsOfElementInSequenceProcess()
    {
        string inputLengthOfSequence = Console.ReadLine();
        short lengthOfSequence = short.Parse(inputLengthOfSequence);

        // Filling the sequence with numbers.
        int[] sequenceOfNumbers = new int[lengthOfSequence];

        for (int i = 0; i < lengthOfSequence; i++)
        {
            string inputSequenceOfNumbers = Console.ReadLine();
            sequenceOfNumbers[i] = short.Parse(inputSequenceOfNumbers);
        }

        string inputNumberToCheck = Console.ReadLine();
        int numberToCheck = int.Parse(inputNumberToCheck);
        int timesRepeated = CountRepetitionsOfElement(numberToCheck, sequenceOfNumbers);

        Console.WriteLine(timesRepeated);
    }

    static int CountRepetitionsOfElement(int element, int[] sequenceOfNumbers)
    {
        int countRepetitions = 0;

        for (int i = 0; i < sequenceOfNumbers.Length; i++)
        {
            if (sequenceOfNumbers[i] == element)
            {
                countRepetitions++;
            }
        }

        return countRepetitions;
    }
}
