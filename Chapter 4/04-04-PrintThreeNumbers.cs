using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter04.Task04.PrintNumbers
{
    class PrintNumbers
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            Console.WriteLine("{0,-10:X}{1,-10:F2}{2,-10:F2}",firstNumber, secondNumber, thirdNumber);
        }
    }
}
