using System;
using System.Numerics;
using System.Globalization;
using System.Threading;

class IntegerAndFloatingPointConvertor
{
    private const char TURN_ON_BIT = '1';
    private const char TURN_OFF_BIT = '0';
    private const char FLOATING_POINT = '.';
    private const byte EXPONENT_SIZE = 127;

    static void Main(string[] args)
    {
        string inputNumber = Console.ReadLine();

        string binaryRepresentation = String.Empty;

        BigInteger integerNumber = 0;
        bool isInteger = BigInteger.TryParse(inputNumber, out integerNumber);
        BigInteger copyOfIntegerPart = integerNumber;
        if (isInteger)
        {
            byte lengthOfBits = 0;
            if (copyOfIntegerPart < 0)
            {
                if (copyOfIntegerPart >= sbyte.MinValue)
                {
                    copyOfIntegerPart = copyOfIntegerPart ^ sbyte.MinValue;
                    lengthOfBits = 8;
                }
                else if (copyOfIntegerPart >= short.MinValue)
                {
                    copyOfIntegerPart = copyOfIntegerPart ^ short.MinValue;
                    lengthOfBits = 16;
                }
                else if (copyOfIntegerPart >= int.MinValue)
                {
                    copyOfIntegerPart = copyOfIntegerPart ^ int.MinValue;
                    lengthOfBits = 32;
                }
            }

            while (copyOfIntegerPart != 0)
            {
                int remainder = (int)(copyOfIntegerPart % 2);
                binaryRepresentation = remainder + binaryRepresentation;

                copyOfIntegerPart = copyOfIntegerPart / 2;
            }

            if (lengthOfBits > 0)
            {
                for (int j = binaryRepresentation.Length; j < lengthOfBits; j++)
                {
                    if (lengthOfBits - 1 == j)
                    {
                        binaryRepresentation = TURN_ON_BIT + binaryRepresentation;
                    }
                    else
                    {
                        binaryRepresentation = TURN_OFF_BIT + binaryRepresentation;
                    }
                }
            }
        }
        else
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("bg-BG", false); //CultureInfo.InvariantCulture;
            float floatNumber = float.Parse(inputNumber);

            // Calculation of integer part of floting point number.
            long integerPart = (int)floatNumber;
            if (integerPart == 0)
            {
                binaryRepresentation = binaryRepresentation + integerPart;
            }
            else
            {
                integerPart = Math.Abs(integerPart);
                while (integerPart != 0)
                {
                    byte remainder = (byte)(integerPart % 2);

                    binaryRepresentation = remainder + binaryRepresentation;

                    integerPart = integerPart / 2;
                }
            }

            binaryRepresentation += '.';

            // Calculation mantissa of floating point number.
            float fractionalPart = (floatNumber % 1) * 2;
            int fractionalPartRemainder = 0;
            do
            {
                fractionalPartRemainder = (int)Math.Abs(fractionalPart) % 2;
                binaryRepresentation = binaryRepresentation + fractionalPartRemainder;
                fractionalPart = (fractionalPart % 1) * 2;
            }
            while (fractionalPart != 0.0f);

            int bias = 0;
            int dotPosition = 0;

            string mantissa = String.Empty;
            if ((int)floatNumber > 0)
            {
                dotPosition = binaryRepresentation.IndexOf(FLOATING_POINT);
                for (int j = 0; j < binaryRepresentation.Length; j++)
                {
                    if ((j == 0) || (binaryRepresentation[j] == FLOATING_POINT))
                    {
                        continue;
                    }

                    mantissa = mantissa + binaryRepresentation[j];
                }

                bias = dotPosition - 1;
            }
            else
            {
                int firstTurnOnBitPosition = binaryRepresentation.IndexOf(TURN_ON_BIT);
                dotPosition = binaryRepresentation.IndexOf('.');
                decimal zeroNumber = 0M;
                if (firstTurnOnBitPosition >= zeroNumber)
                {
                    if ((int)floatNumber == zeroNumber)
                    {
                        bias = 1 - firstTurnOnBitPosition;
                    }
                    else
                    {
                        bias = dotPosition - 1;
                    }

                    for (int j = 0; j < binaryRepresentation.Length; j++)
                    {
                        if ((firstTurnOnBitPosition + 1 > j) || (binaryRepresentation[j] == FLOATING_POINT))
                        {
                            continue;
                        }

                        mantissa = mantissa + binaryRepresentation[j];
                    }
                }
            }

            if (mantissa.Length < 23)
            {
                for (int j = mantissa.Length; j < 23; j++)
                {
                    mantissa = mantissa + TURN_OFF_BIT;
                }
            }

            // Calculation of exponent part of floating point number.
            int exponent = EXPONENT_SIZE + bias;
            string exponentBinaryRepresentation = String.Empty;

            if ((floatNumber > 0.0) || (floatNumber < 0.0))
            {
                while (exponent > 0.0)
                {
                    fractionalPartRemainder = exponent % 2;
                    exponentBinaryRepresentation = fractionalPartRemainder + exponentBinaryRepresentation;

                    exponent = exponent / 2;
                }
            }

            if (exponentBinaryRepresentation.Length < 8)
            {
                for (int j = exponentBinaryRepresentation.Length; j < 8; j++)
                {
                    if (j == 8 - 1)
                    {
                        if ((int)floatNumber < -1)
                        {
                            exponentBinaryRepresentation = TURN_ON_BIT + exponentBinaryRepresentation;
                        }
                        else
                        {
                            exponentBinaryRepresentation = TURN_OFF_BIT + exponentBinaryRepresentation;
                        }
                    }
                    else
                    {
                        exponentBinaryRepresentation = TURN_OFF_BIT + exponentBinaryRepresentation;
                    }
                }
            }

            string fullBinaryRepresentationOfFloat = null;
            if (floatNumber >= 0.0f)
            {
                fullBinaryRepresentationOfFloat = fullBinaryRepresentationOfFloat + TURN_OFF_BIT + " ";
            }
            else
            {
                fullBinaryRepresentationOfFloat = fullBinaryRepresentationOfFloat + TURN_ON_BIT + " ";
            }

            for (int j = 0; j < exponentBinaryRepresentation.Length; j++)
            {
                fullBinaryRepresentationOfFloat = fullBinaryRepresentationOfFloat + exponentBinaryRepresentation[j];
            }

            fullBinaryRepresentationOfFloat = fullBinaryRepresentationOfFloat + ' ';

            for (int j = 0; j < mantissa.Length; j++)
            {
                fullBinaryRepresentationOfFloat = fullBinaryRepresentationOfFloat + mantissa[j];
            }

            binaryRepresentation = fullBinaryRepresentationOfFloat;

            if (binaryRepresentation.Length < 23)
            {
                for (int j = mantissa.Length; j < 23; j++)
                {
                    mantissa = mantissa + TURN_OFF_BIT;
                }
            }
        }

        Console.WriteLine("{0}", binaryRepresentation);
    }
}
