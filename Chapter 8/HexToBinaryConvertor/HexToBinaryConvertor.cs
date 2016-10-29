using System;
using System.Text;

class HexToBinaryConvertor
{
    static void Main(string[] args)
    {
        string hexadecimal = Console.ReadLine();

        //Hexadecimal to Decimal
        int decimalNumber = 0;
        int grade = 0;
        for (int i = hexadecimal.Length - 1; i >= 0; i--)
        {
            string symbol = hexadecimal[i].ToString();
            int symbolValue = 0;
            bool isSymbolValidInt = int.TryParse(symbol, out symbolValue);
            if (!isSymbolValidInt)
            {
                switch (symbol)
                {
                    case "A": symbolValue = 10; break;
                    case "B": symbolValue = 11; break;
                    case "C": symbolValue = 12; break;
                    case "D": symbolValue = 13; break;
                    case "E": symbolValue = 14; break;
                    case "F": symbolValue = 15; break;
                    default:
                        Console.WriteLine("{0} is nvalid hex symbol", symbol);
                        break;
                }
            }
            double currentGrade = Math.Pow(16, grade);
            decimalNumber += (int)currentGrade * symbolValue;
            grade++;
        }

        //Decimal to Binary
        StringBuilder binaryRepresentation = new StringBuilder();
        do
        {
            int remainder = decimalNumber % 2;
            decimalNumber /= 2;
            binaryRepresentation.Append(remainder);
        } while (decimalNumber > 0);

        StringBuilder binaryRepresentationReversed = new StringBuilder();
        for (int i = binaryRepresentation.Length - 1; i >= 0; i--)
        {
            binaryRepresentationReversed.Append(binaryRepresentation[i]);
        }

        Console.WriteLine(binaryRepresentationReversed);
    }
}
