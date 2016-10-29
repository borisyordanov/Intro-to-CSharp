using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chapter04.Task08.TheGreatestNumber
{
    class TheGreatestNumber
    {
        static void Main(string[] args)
        {
            double firstNumber = double.MinValue;
            double secondNumber = double.MinValue;
            double thirdNumber = double.MinValue;
            double fourthNumber = double.MinValue;
            double fifthNumber = double.MinValue;

            if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
            {
                Console.WriteLine(firstNumber);
            }
            else if (secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
            {
                Console.WriteLine(secondNumber);
            }
            else if (thirdNumber > fourthNumber && thirdNumber > fifthNumber)
            {
                Console.WriteLine(thirdNumber);
            }
            else if (fourthNumber > fifthNumber)
            {
                Console.WriteLine(fourthNumber);
            }
            else
            {
                Console.WriteLine(fifthNumber);
            }
        }
    }
}
