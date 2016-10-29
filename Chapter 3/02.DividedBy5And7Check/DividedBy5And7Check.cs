using System;

namespace _02.DividedBy5And7Check
{
    class DividedBy5And7Check
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isDiveded = (number % 5 == 0) && (number % 7 == 0);
            Console.WriteLine(isDiveded);
        }
    }
}
