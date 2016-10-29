using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _05.CalculatesTrapeziumArea
{
    class CalculatesTrapeziumArea
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double area = (a + b) * h / 2;
            Console.WriteLine(area);
        }
    }
}
