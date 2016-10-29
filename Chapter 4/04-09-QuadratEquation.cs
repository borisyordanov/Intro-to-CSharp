using System;

namespace QuadraticEquation
{
    class Program
    {
        static void Main(string[] args)
        {

            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double d;
            double x;
            double x1;
            double x2;
            double x12;

            if (a == 0)
            {
                if (b == 0)
                {
                    if (c == 0)
                    {
                        Console.WriteLine("Every x is solution");
                    }
                    else
                    {
                        Console.WriteLine("There is no solution");
                    }
                }
                else
                {
                    x = -(c / b);
                    Console.WriteLine(x);
                }
                
            }
            else
            {
                d = ((b * b) - (4 * a * c));
                if (d < 0)
                {
                    Console.WriteLine("No real roots");
                }
                else if (d > 0)
                {
                    x1 = ((-b) + Math.Sqrt(d)) / (2 * a);
                    x2 = ((-b) - Math.Sqrt(d)) / (2 * a);
                    Console.WriteLine("{0:00.000} \n {1:00.000}", x1, x2);
                }
                else
                {
                    x12 = ((-b) / (2 * a));
                    Console.WriteLine("{0}", x12);
                }
            }
        }
    }
}
