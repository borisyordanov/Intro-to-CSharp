using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using System.Diagnostics;

namespace Chapter04.Task12.SequenceOfFibonacci
{
    class SequenceOfFibonacci
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger lastNumber = 0;
            BigInteger newNumber = 1;
            BigInteger beforeLastNumber;
            if (n == 0)
            {
            }
            else if (n == 1)
            {
                Console.WriteLine(lastNumber);
            }
            else if (n == 2)
            {
                Console.WriteLine("{0}, {1}", lastNumber, newNumber);
            }
            else
            {
                Console.Write("{0}, {1}, ", lastNumber, newNumber);

                for (int i = 2; i < n; i++)
                {
                    beforeLastNumber = lastNumber;
                    lastNumber = newNumber;
                    newNumber = beforeLastNumber + lastNumber;
                    if (i < n-1)
                    {
                        Console.Write("{0}, ", newNumber);
                    }
                    else
                    {
                        Console.WriteLine(newNumber);
                    }
                }
            }
        }
    }
}
