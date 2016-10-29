using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _08.IsInCircle
{
    class IsInCircle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 5;

            bool isInCircle = (x * x + y * y) < radius * radius;
            Console.WriteLine(isInCircle);
        }
    }
}
