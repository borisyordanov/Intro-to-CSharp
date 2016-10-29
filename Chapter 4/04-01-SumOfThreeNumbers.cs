using System;

namespace ThreeIntegerNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            int third = int.Parse(Console.ReadLine());
            long sum = 0;
            sum = (long)first + (long)second + (long)third;
            Console.WriteLine("{0}",sum);
        }
    }
}
