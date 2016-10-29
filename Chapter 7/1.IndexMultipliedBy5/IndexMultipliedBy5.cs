using System;

class IndexMultipliedBy5
{
    static void Main(string[] args)
    {
        int multiplier = 5;
        int[] arrayOfNumbers = new int[20];
        for (int index = 0; index < arrayOfNumbers.GetLength(0); index++)
        {
            arrayOfNumbers[index] = index * multiplier;
            Console.WriteLine(arrayOfNumbers[index]);
        }
    }
}
