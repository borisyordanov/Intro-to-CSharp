using System;

class SelectionSort
{
    static void Main(string[] args)
    {
        string enterLength = Console.ReadLine();
        int arrayLength = int.Parse(enterLength);
        int[] arrayOfNumbers = new int[arrayLength];
        string enterDigit;
        for (int count = 0; count < arrayLength; count++)
        {
            enterDigit = Console.ReadLine();
            arrayOfNumbers[count] = int.Parse(enterDigit);
        }
        for (int count = 0; count < arrayLength - 1; count++)
        {
            int indexMin = count;
            bool change = false;
            for (int miniCount = count + 1; miniCount < arrayLength; miniCount++)
            {
                if (arrayOfNumbers[indexMin] > arrayOfNumbers[miniCount])
                {
                    indexMin = miniCount;
                    change = true;
                }
            }
            if (change)
            {
                arrayOfNumbers[count] ^= arrayOfNumbers[indexMin];
                arrayOfNumbers[indexMin] ^= arrayOfNumbers[count];
                arrayOfNumbers[count] ^= arrayOfNumbers[indexMin];
                //other method to exchange
                //arrayOfNumbers[count] += arrayOfNumbers[indexMin];
                //arrayOfNumbers[indexMin] = arrayOfNumbers[count] - arrayOfNumbers[indexMin];
                //arrayOfNumbers[count] = arrayOfNumbers[count] - arrayOfNumbers[indexMin];
            }
        }
        foreach (int element in arrayOfNumbers)
        {
            Console.WriteLine(element);
        }
    }
}

