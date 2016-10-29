﻿using System;

class RealToFloatConverter
{
    static void Main(string[] args)
    {
        string inputRealNumber = Console.ReadLine();

        int integer;
        bool numberIsInt = int.TryParse(inputRealNumber, out integer);
        if (numberIsInt)
        {
            if (integer < 0)
            {
                integer = integer ^ int.MinValue;
            }
            string integerBinary = ConvertIntToBinary(integer);
            Console.WriteLine(integerBinary);
        }
        else
        {
            char sign = '0';
            if (inputRealNumber[0] == '-')
            {
                sign = '1';
            }
            Console.WriteLine(sign);
            inputRealNumber = FixFloatSign(inputRealNumber);

            float realNumber = float.Parse(inputRealNumber);
            realNumber = Math.Abs(realNumber);

            if (realNumber > 0)
            {
                float fractalPart = realNumber % 1;
                int wholePart = (int)(realNumber - fractalPart);

                string fractionPartBinary;
                string exponentBinary;
                ConvertFloatToBinaryIEEE754(fractalPart, wholePart,
                    out fractionPartBinary, out exponentBinary);

                string exponent = FillExponent(exponentBinary);
                Console.WriteLine(exponent);

                string mantisa = FillMantisa(fractionPartBinary);
                Console.WriteLine(mantisa);
            }
            else
            {
                Console.WriteLine(new string('0', 8));
                Console.WriteLine(new string('0', 23));
            }
        }
    }

    private static string FixFloatSign(string inputRealNumber)
    {
        string fixedNumber = null;
        for (int i = 0; i < inputRealNumber.Length; i++)
        {
            if (inputRealNumber[i] == ',')
            {
                fixedNumber += '.';
            }
            else
            {
                fixedNumber += inputRealNumber[i];
            }
        }
        return fixedNumber;
    }

    private static void ConvertFloatToBinaryIEEE754(
        float fractalPart,
        int wholePart,
        out string fractionPartBinary,
        out string exponentBinary)
    {
        fractionPartBinary = ConvertFractionToBinary(fractalPart);
        int exponentValue = 0;
        string wholePartBinary = null;

        if (wholePart >= 1)
        {
            wholePartBinary = ConvertIntToBinary(wholePart);
            exponentValue = 127 + wholePartBinary.Length - 1;
            string startOfFraction = RemoveFirstBits(wholePartBinary, 1);
            fractionPartBinary = startOfFraction + fractionPartBinary;
        }
        else //special case when the number is between 0 and 1, for example 0.001
        {
            exponentValue = CalculateNegativeExponentCase(fractionPartBinary);
            fractionPartBinary = RemoveFirstBits(fractionPartBinary, exponentValue + 1);
            exponentValue = 127 - exponentValue - 1;
        }
        exponentBinary = ConvertIntToBinary(exponentValue);
    }

    private static string FillExponent(string exponentBinary)
    {
        string exponent = null;
        if (exponentBinary.Length < 8) //filling all 8 bits
        {
            string zeroesFill = new string('0', 8 - exponentBinary.Length);
            exponent = zeroesFill + exponentBinary;
        }
        else
        {
            exponent = exponentBinary;
        }
        return exponent;
    }

    private static string FillMantisa(string fractionPartBinary)
    {
        string mantisa = null;
        if (fractionPartBinary.Length < 23) // filling all 23 bits
        {
            string zeroesFill = new string('0', 23 - fractionPartBinary.Length);
            mantisa = fractionPartBinary + zeroesFill;
        }
        else
        {
            for (int i = 0; i < 23; i++)
            {
                mantisa = mantisa + fractionPartBinary[i];
            }
        }
        return mantisa;
    }

    private static string RemoveFirstBits(string wholePartBinary, int bitsCount)
    {
        string wholePartWitoutFirstBit = null;
        for (int i = bitsCount; i < wholePartBinary.Length; i++)
        {
            wholePartWitoutFirstBit = wholePartWitoutFirstBit + wholePartBinary[i];
        }
        return wholePartWitoutFirstBit;
    }

    private static int CalculateNegativeExponentCase(string fractionPartBinary)
    {
        int firstOneSignPossition = 0;
        for (int i = 0; i < fractionPartBinary.Length; i++)
        {
            if (fractionPartBinary[i] == '1')
            {
                firstOneSignPossition = i;
                break;
            }
        }
        return firstOneSignPossition;
    }

    private static string ConvertFractionToBinary(float fractalPart)
    {
        string binaryRepresentation = null;
        int bits = 0;
        float fractal = fractalPart;
        while (fractalPart != 0 && bits <= 46)
        {
            float multiplied = fractal * 2;
            fractal = multiplied % 1;
            float currentBit = multiplied - fractal;
            binaryRepresentation = binaryRepresentation + currentBit;
            bits++;
        }
        return binaryRepresentation;
    }

    private static string ConvertIntToBinary(int wholePart)
    {
        string binaryRepresentation = null;
        while (wholePart != 0)
        {
            int currentBit = wholePart % 2;
            wholePart = wholePart / 2;
            binaryRepresentation = currentBit + binaryRepresentation;
        }
        return binaryRepresentation;
    }
}
