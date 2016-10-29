using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class FractionTest
{
    public static void TestPrint()
    {
        Fraction a = Fraction.Parse(" -1 / 8");
        Fraction b = new Fraction(7, 8, 0);

        Console.WriteLine("Parse : \"-1 / 8\" : {0}", a);
        Console.WriteLine("a.Numerator : {0}", a.Numerator);
        Console.WriteLine("a.Denominator : {0}", a.Denominator);
        Console.WriteLine("a.DecimalValue : {0}", a.DecimalValue);

        Console.WriteLine("\nConstructor ///0 for sign//");
        Console.WriteLine("Fraction b = new Fraction(7, 8, 0) : {0}", b);
        
        Console.WriteLine("b + a = {0}", b + a);
    }
}

