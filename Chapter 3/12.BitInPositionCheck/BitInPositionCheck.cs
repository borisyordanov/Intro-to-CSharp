using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12.BitInPositionCheck
{
    class BitInPositionCheck
    {
        static void Main(string[] args)
        {
            int v = int.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());

            bool isBitOne = (v >> p & 1) == 1;
            Console.WriteLine(isBitOne);
        }
    }
}
