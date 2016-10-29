using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06.CalculatesRectangle
{
    class CalculatesRectangle
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());

            double area = a * b;
            Console.WriteLine(area);

            double perimeter = 2 * (a + b);
            Console.WriteLine(perimeter);
        }
    }
}
