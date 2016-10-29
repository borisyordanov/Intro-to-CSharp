using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _09.InCircleOutRectangle
{
    class InCircleOutRectangle
    {
        static void Main(string[] args)
        {
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());
            int radius = 5;

            bool isInCircle = (x * x + y * y) < radius * radius;
            bool isInRectangle = x > -1 && x < 5 && y > 1 && y < 5;

            Console.WriteLine(isInCircle && !isInRectangle);
        }
    }
}
