using System;

class BinaryToDdecimalAndHexConvertor
{

    static void Main(string[] args)
    {
        // Convert from binary to decimal.
        string inputBinaryNumber = Console.ReadLine();
        int[] binaryNumber = new int[inputBinaryNumber.Length];
        for (int i = 0; i < inputBinaryNumber.Length; i++)
        {
            if (inputBinaryNumber[i] == '1')
            {
                binaryNumber[i] = 1;
            }
            else
            {
                binaryNumber[i] = 0;
            }
        }
        long decimalNumber = 0;
        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += (long)(binaryNumber[i] * Math.Pow(2, binaryNumber.Length - i - 1));
        }
        Console.WriteLine(decimalNumber);

        // Convert from decimal to hexadecimal.
        string hexadecimalNumber = String.Empty;
        do
        {
            int decimalDigit = (int)(decimalNumber % 16);

            if (decimalDigit > 9)
            {
                char hexadecimalDigit = ' ';
                switch (decimalDigit)
                {
                    case 10:
                        hexadecimalDigit = 'A';
                        break;
                    case 11:
                        hexadecimalDigit = 'B';
                        break;
                    case 12:
                        hexadecimalDigit = 'C';
                        break;
                    case 13:
                        hexadecimalDigit = 'D';
                        break;
                    case 14:
                        hexadecimalDigit = 'E';
                        break;
                    case 15:
                        hexadecimalDigit = 'F';
                        break;
                    default:
                        break;
                }
                hexadecimalNumber = hexadecimalDigit + hexadecimalNumber;
            }
            else
            {
                hexadecimalNumber = decimalDigit + hexadecimalNumber;
            }
            decimalNumber /= 16;
        } while (decimalNumber != 0);
        Console.WriteLine(hexadecimalNumber);
    }
}
