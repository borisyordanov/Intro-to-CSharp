using System;
using System.Numerics;

class NotationSToNotationDConverter
{
    static void Main(string[] args)
    {
        string inputBaseS = Console.ReadLine();
        byte baseS = byte.Parse(inputBaseS);

        string inputBaseD = Console.ReadLine();
        byte baseD = byte.Parse(inputBaseD);

        string representationOfNotationWithBaseS = Console.ReadLine().ToUpper();

        // Reverse representation of numeral system S
        string reversedNotationS = null;
        for (int i = 0; i < representationOfNotationWithBaseS.Length; i++)
        {
            reversedNotationS = representationOfNotationWithBaseS[i] + reversedNotationS;
        }

        // Convert from numeral system S to Decimal numeral system
        BigInteger decimalRepresentation = 0;
        for (int i = 0; i < reversedNotationS.Length; i++)
        {
            byte multiplier = 0;

            if (char.IsNumber(reversedNotationS[i]))
            {
                multiplier = (byte)(reversedNotationS[i] - '0');
            }
            else
            {
                char character = reversedNotationS[i];
                switch (character)
                {
                    case 'A':
                        multiplier = 10;
                        break;
                    case 'B':
                        multiplier = 11;
                        break;
                    case 'C':
                        multiplier = 12;
                        break;
                    case 'D':
                        multiplier = 13;
                        break;
                    case 'E':
                        multiplier = 14;
                        break;
                    case 'F':
                        multiplier = 15;
                        break;
                }
            }

            decimalRepresentation += multiplier * (BigInteger)Math.Pow(baseS, i);
        }

        // Convert from Decimal numeral system to numeral system D
        string representationOfNumeralSystem_D = null;
        do
        {
            char character = ' ';
            byte remainder = (byte)(decimalRepresentation % baseD);
            if ((remainder >= 0) && (remainder <= 9))
            {
                character = (char)(remainder + '0');
            }
            else
            {
                switch (remainder)
                {
                    case 10:
                        character = 'A';
                        break;
                    case 11:
                        character = 'B';
                        break;
                    case 12:
                        character = 'C';
                        break;
                    case 13:
                        character = 'D';
                        break;
                    case 14:
                        character = 'E';
                        break;
                    case 15:
                        character = 'F';
                        break;
                }
            }

            representationOfNumeralSystem_D = character + representationOfNumeralSystem_D;

            decimalRepresentation = decimalRepresentation / baseD;
        }
        while (decimalRepresentation > 0);

        // Print representation of numeral system D       	 
        Console.WriteLine(representationOfNumeralSystem_D);
    }
}
