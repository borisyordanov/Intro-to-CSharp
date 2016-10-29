using System;

class NeighboursComparer
{
    private static decimal[] elements;

    static void Main(string[] args)
    {
        InputElementsInArray();
        string inputPossition = Console.ReadLine();
        int possitionOfElement = int.Parse(inputPossition);

        int compareResult = CompareToNeighbours(possitionOfElement);
        Console.WriteLine(compareResult);
    }

    /// <summary>
    /// Read elements from console and fill them in array.
    /// </summary>
    private static void InputElementsInArray()
    {
        int numberOfElements = int.Parse(Console.ReadLine());
        elements = new decimal[numberOfElements];
        for (int i = 0; i < elements.Length; i++)
        {
            string consoleInput = Console.ReadLine();
            elements[i] = decimal.Parse(consoleInput);
        }
    }

    /// <summary>
    /// Compares neighbours of given element in array.
    /// </summary>
    /// <param name="possitionOfElement">The index of the element.</param>
    /// <returns></returns>
    private static int CompareToNeighbours(int possitionOfElement)
    {
        int compareResult = 0;
        if ((possitionOfElement > 0) &&
            (possitionOfElement < elements.Length - 1))
        {
            decimal element = elements[possitionOfElement];
            decimal elementLeft = elements[possitionOfElement - 1];
            decimal elementRight = elements[possitionOfElement + 1];
            if (element > elementLeft && element > elementRight)
            {
                compareResult = 1;
            }
            else if (element < elementLeft && element < elementRight)
            {
                compareResult = -1;
            }
        }
        return compareResult;
    }
}
