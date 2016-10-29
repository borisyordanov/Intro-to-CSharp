using System;

class IndexOfElementBiggerThanNeigbors
{
    static void Main(string[] args)
    {
        string inputLengthOfSequence = Console.ReadLine();
        short lengthOfSequence = short.Parse(inputLengthOfSequence);

        decimal[] sequenceOfNumbers = ReadIntegerNumbers(lengthOfSequence);
        int indexOfElementWichIsGreaterThanNeigbors = FindIndex(sequenceOfNumbers);

        Console.WriteLine(indexOfElementWichIsGreaterThanNeigbors);
    }

    /// <summary>
    /// Reads integer numbers.
    /// </summary>
    /// <param name="lengthOfSequence">The length of sequence.</param>
    /// <returns></returns>
    private static decimal[] ReadIntegerNumbers(short lengthOfSequence)
    {
        decimal[] sequenceOfNumbers = new decimal[lengthOfSequence];

        for (int i = 0; i < lengthOfSequence; i++)
        {
            string inputNumber = Console.ReadLine();

            decimal currentNumber = decimal.Parse(inputNumber);

            sequenceOfNumbers[i] = currentNumber;
        }

        return sequenceOfNumbers;
    }

    /// <summary>
    /// Gets the index of element wich is greater than neigbors.
    /// </summary>
    /// <param name="sequenceOfNumbers">The sequence of numbers.</param>
    /// <returns></returns>
    static int FindIndex(decimal[] sequenceOfNumbers)
    {
        int index = -1;

        int lengthOfArray = sequenceOfNumbers.Length;

        for (int i = 1; i < lengthOfArray; i++)
        {
            bool isElementGreaterThanNeigbors = IsElementGreaterThanNeighbors(i, sequenceOfNumbers);

            if (isElementGreaterThanNeigbors)
            {
                index = i;

                break;
            }
        }

        return index;
    }

    /// <summary>
    /// Determines whether the specified element of index is greater than neighbors.
    /// </summary>
    /// <param name="index">The index.</param>
    /// <param name="sequenceOfNumbers">The sequence of numbers.</param>
    /// <returns>
    ///   <c>true</c> if specified element of index is greater than neighbors; otherwise, <c>false</c>.
    /// </returns>
    private static bool IsElementGreaterThanNeighbors(int index, decimal[] sequenceOfNumbers)
    {
        bool isGreater = false;

        int lengthOfSequence = sequenceOfNumbers.Length - 1;
        bool isPreviousIndexIsInBounds = IsInRange(index - 1, 0, lengthOfSequence);
        bool isCurrentIndexIsInBounds = IsInRange(index, 0, lengthOfSequence);
        bool isNextIndexIsInBounds = IsInRange(index + 1, 0, lengthOfSequence);

        if (isPreviousIndexIsInBounds &&
            isCurrentIndexIsInBounds &&
            isNextIndexIsInBounds)
        {
            decimal previousElement = sequenceOfNumbers[index - 1];
            decimal currentElement = sequenceOfNumbers[index];
            decimal nextElement = sequenceOfNumbers[index + 1];

            bool isGreaterThanPreviousElement = IsGreater(currentElement, previousElement);
            bool isGreaterThanNextElement = IsGreater(currentElement, nextElement);
            if (isGreaterThanPreviousElement && isGreaterThanNextElement)
            {
                isGreater = true;
            }
        }

        return isGreater;
    }

    /// <summary>
    /// Determines whether the specified source is greater.
    /// </summary>
    /// <param name="source">The source.</param>
    /// <param name="bound">The bound.</param>
    /// <returns>
    ///   <c>true</c> if the specified source is greater; otherwise, <c>false</c>.
    /// </returns>
    private static bool IsGreater(decimal source, decimal bound)
    {
        bool isGreater = false;

        if (source > bound)
        {
            isGreater = true;
        }

        return isGreater;
    }

    /// <summary>
    /// Determines whether the specified number is in range.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <param name="minRange">The min range.</param>
    /// <param name="maxRange">The max range.</param>
    /// <returns>
    ///   <c>true</c> if the specified number is in range; otherwise, <c>false</c>.
    /// </returns>
    private static bool IsInRange(int number, int minRange, int maxRange)
    {
        bool isInRange = false;

        if ((number >= minRange) &&
            (number <= maxRange))
        {
            isInRange = true;
        }

        return isInRange;
    }
}
