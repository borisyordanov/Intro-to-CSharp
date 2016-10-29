using System;

class ArraySearchAndSort
{
    static int[] array;

    static void Main(string[] args)
    {
        ReadArrayFromConsole();

        int indexOfGreatest = FindIndexOfGreatestInGivenRangeInArray(0, array.Length - 1);
        int greatest = array[indexOfGreatest];
        Console.WriteLine(greatest);

        SortArrayDescendingOrder();
        PrintArrayOnConsole();

        SortArrayAscendingOrder();
        PrintArrayOnConsole();
    }

    /// <summary>
    /// Reads the array from console.
    /// </summary>
    private static void ReadArrayFromConsole()
    {
        string inputSizeOfArray = Console.ReadLine();
        int sizeOfArray = int.Parse(inputSizeOfArray);
        array = new int[sizeOfArray];

        for (int i = 0; i < sizeOfArray; i++)
        {
            string inputNumber = Console.ReadLine();
            array[i] = int.Parse(inputNumber);
        }
    }

    /// <summary>
    /// Finds the index of greatest number in given range in array.
    /// </summary>
    /// <param name="startIndex">The start index.</param>
    /// <param name="endIndex">The end index.</param>
    /// <returns>Index of the greatest number</returns>
    private static int FindIndexOfGreatestInGivenRangeInArray(int startIndex, int endIndex)
    {
        int greatest = array[startIndex];
        int indexOfGreatest = startIndex;
        for (int i = startIndex; i <= endIndex; i++)
        {
            if (greatest < array[i])
            {
                greatest = array[i];
                indexOfGreatest = i;
            }
        }
        return indexOfGreatest;
    }

    /// <summary>
    /// Prints the array on the console.
    /// </summary>
    private static void PrintArrayOnConsole()
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write("{0} ", array[i]);
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Sorts the array in descending order.
    /// </summary>
    private static void SortArrayDescendingOrder()
    {
        int arrayLength = array.Length;
        for (int i = 0; i < arrayLength; i++)
        {
            int indexOfGreatest = FindIndexOfGreatestInGivenRangeInArray(i, arrayLength - 1);
            SwapValuesInArray(i, indexOfGreatest);
        }
    }

    /// <summary>
    /// Sorts the array in ascending order.
    /// </summary>
    private static void SortArrayAscendingOrder()
    {
        int arrayLength = array.Length;
        for (int i = arrayLength - 1; i >= 0; i--)
        {
            int indexOfGreatest = FindIndexOfGreatestInGivenRangeInArray(0, i);
            SwapValuesInArray(i, indexOfGreatest);
        }
    }

    /// <summary>
    /// Swaps two values in array with given indexes.
    /// </summary>
    /// <param name="firstOperand">Index of the first operand.</param>
    /// <param name="secondOperand">Index of the second operand.</param>
    private static void SwapValuesInArray(int firstOperand, int secondOperand)
    {
        int oldValue = array[firstOperand];
        array[firstOperand] = array[secondOperand];
        array[secondOperand] = oldValue;
    }
}
