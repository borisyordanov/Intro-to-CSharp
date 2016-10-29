using System;

class CompareElementOfIntArray
{
    static void Main(string[] args)
    {
        string enterLength = Console.ReadLine();
        int firstArrayLength = int.Parse(enterLength);
        int[] firstArray = new int[firstArrayLength];
        
        enterLength = Console.ReadLine();
        int secondArrayLength = int.Parse(enterLength);
        int[] secondArray = new int[secondArrayLength];

        if (firstArray.GetLength(0) != secondArray.GetLength(0))
        {
            Console.WriteLine("First array = second array - > False");
        }
        else
        {
            string enterNumber = string.Empty;
            for (int index = 0; index < firstArray.GetLength(0); index++)
            {
                enterNumber = Console.ReadLine();
                firstArray[index] = int.Parse(enterNumber);
            }

            for (int index = 0; index < secondArray.GetLength(0); index++)
            {
                enterNumber = Console.ReadLine();
                secondArray[index] = int.Parse(enterNumber);
            }

            bool isEqual = true;
            for (int index = 0; index < firstArray.GetLength(0); index++)
            {
               if (firstArray[index] != secondArray[index])
                {
                    isEqual = false;
                    break;
                } 
            }
            Console.WriteLine("First array = second array - > {0}",isEqual);           
        }
    }
}

