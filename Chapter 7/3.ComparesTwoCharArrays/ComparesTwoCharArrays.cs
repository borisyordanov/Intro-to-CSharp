using System;


class ComparesTwoCharArrays
{
    static void Main(string[] args)
    {
        string enterLength = Console.ReadLine();
        int firstArrayLength = int.Parse(enterLength);
        

        enterLength = Console.ReadLine();
        int secondArrayLength = int.Parse(enterLength);
        

        if (firstArrayLength == secondArrayLength)
        {
            //enter arrays
            char[] firstArray = new char[firstArrayLength];
            for (int index = 0; index < firstArray.Length; index++)
            {                
                firstArray[index] = char.Parse(Console.ReadLine());
            }
            
            char[] secondArray = new char[secondArrayLength];
            for (int index = 0; index < firstArray.Length; index++)
            {
                secondArray[index] = char.Parse(Console.ReadLine());
            }

            //CompareArrays
            int firstPositionArray = 0;
            for (int count = 0; count < firstArray.Length; count++)
            {
                if (firstArray[count] != secondArray[count])
                {
                    if (firstArray[count] < secondArray[count])
                    {
                        firstPositionArray = 1;
                        break;
                    }
                    else
                    {
                        firstPositionArray = 2;
                        break;
                    }
                }
            }
            //print result
            if (firstPositionArray == 1)
            {
                Console.WriteLine("First is : First array.");
            }
            else if(firstPositionArray == 2)
            {
                Console.WriteLine("First is : Second array.");
            }
            else if (firstPositionArray == 0)
            {
                Console.WriteLine("First array = Second array");
            }
        }        
        else if (firstArrayLength < secondArrayLength)
        {
            Console.WriteLine("First is : First array.");
        }
        else
        {
            Console.WriteLine("First is : Second array.");
        }
    }
}

