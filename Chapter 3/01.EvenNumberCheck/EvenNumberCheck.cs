using System;

namespace _01.EvenNumberCheck
{
    class EvenNumberCheck
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            bool isEven = number % 2 == 0;
            Console.WriteLine(isEven);
        }
    }
}