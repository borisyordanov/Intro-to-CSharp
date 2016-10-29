using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;


class Fraction
{
    int sign;
    int denominator;
    int numerator;

    decimal decFraction;

    public Fraction(int numerator, int denominator, int sign)
    {
        this.numerator = numerator;
        this.denominator = denominator;
        this.sign = sign;

        if (this.numerator == 0)
        {
            this.decFraction = 0.00M;
        }
        else
        {
            this.decFraction = Convert.ToDecimal(this.numerator) / Convert.ToDecimal(this.denominator);
        }
    }

    public int Numerator
    {
        get
        {
            return this.numerator;
        }
    }

    public int Denominator
    {
        get
        {
            return this.denominator;
        }
    }

    public int Sign
    {
        get
        {
            return this.sign;
        }
    }

    public decimal DecimalValue
    {
        get
        {
            if (this.Sign == 1)
            {
                return this.decFraction * (-1);
            }
            else
            {
                return this.decFraction;
            }
            
        }
    }

    public static Fraction Parse(string fullFraction)
    {
        int den;
        int num;
        int sign = 0;

        Match match;
        
        string pattern = @"([\-]*)\s*([0-9]+)\s*/\s*([0-9]+)";
        
        if (!Regex.IsMatch(fullFraction, pattern))
        {
            throw new FormatException("Incorrect Format");
        }
        else
        {
            match = Regex.Match(fullFraction, pattern);

            num = int.Parse(match.Groups[2].Value);
            den = int.Parse(match.Groups[3].Value);
        }
        
        if (match.Groups[1].Value != "")
	    {
		    sign = 1;
	    }

        return new Fraction(num, den, sign);
    }


    public static Fraction operator +(Fraction firstFrac, Fraction secondFrac)
    {
        int firstDen = firstFrac.Denominator;
        int secDen = secondFrac.Denominator;
        int sign = 0;

        int finalDen;
        int finalNum;

        int ComonDevisor;

        int firstNum = firstFrac.Numerator;
        int secNum = secondFrac.Numerator;

        int LCM = LeastCommonMultiple(firstDen, secDen);

        firstNum = firstNum * (LCM / firstDen);
        secNum = secNum * (LCM / secDen);

        if (firstFrac.Sign == 1 && secondFrac.Sign == 1)
        {
            finalNum = firstNum + secNum;
            sign = 1;
        }
        else if (firstFrac.Sign == 1)
        {
            finalNum = secNum - firstNum;

            if (finalNum < 0)
            {
                finalNum = finalNum * (-1);
                sign = 1;
            }
        }
        else if (secondFrac.Sign == 1)
        {
            finalNum = firstNum - secNum;

            if (finalNum < 0)
            {
                finalNum = finalNum * (-1);
                sign = 1;
            }
        }
        else
        {
            finalNum = firstNum + secNum;
            sign = 0;
        }



        finalDen = LCM;

        if(finalNum == 0)
        {
            finalDen = 0;
            sign = 0;
        }
        else
        {
            ComonDevisor = GCD(finalNum, firstDen);

            finalDen = finalDen / ComonDevisor;
            finalNum = finalNum / ComonDevisor;
        }

        return new Fraction(finalNum, finalDen, sign);

    }

    static int LeastCommonMultiple(int first, int second)
    {
        return (first * second) / GCD(first, second);
    }

    static int GCD(int first,int second)
    {
        int temp;
        
        while (second != 0)
        {
           temp = second;
           second = first % second;
           first = temp;
        }
        return first;
    }

    public override string ToString()
    {
        if (this.Numerator == 0)
        {
            return "0";
        }
        
        StringBuilder result = new StringBuilder();

        if (this.Sign == 1)
        {
            result.Append("-");
        }

        result.Append(this.Numerator);
        result.Append("/");
        result.Append(this.Denominator);

        return result.ToString();
    }
}

