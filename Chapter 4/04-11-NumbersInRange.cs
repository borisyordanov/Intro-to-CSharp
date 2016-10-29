using System;

class PrintToN
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        string inputNumber = Console.ReadLine();
        sbyte number = sbyte.Parse(inputNumber);

        if (number > 0)
        {
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
        else
        {
            for (int i = 1; i >= number; i--)
            {
                Console.WriteLine(i);
            }
        }
    }
}