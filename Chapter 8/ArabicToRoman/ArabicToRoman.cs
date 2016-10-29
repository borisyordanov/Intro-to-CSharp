using System;

class ArabicToRoman
{
    static void Main(string[] args)
    {
        ushort[] arabicRepresentation = { 1, 4, 5, 9, 10, 40, 50, 90, 100, 400, 500, 900, 1000 };
        string[] romanRepresentation = { "I", "IV", "V", "IX", "X", "XL", "L", "XC", "C", "CD", "D", "CM", "M" };

        string inputArabicNumber = Console.ReadLine();
        int arabicNumber = int.Parse(inputArabicNumber);
        string romanNumber = String.Empty;

        int currentPosition = arabicRepresentation.Length;
        while ((arabicNumber > 0) && (currentPosition > 0))
        {
            while (arabicNumber >= arabicRepresentation[currentPosition - 1])
            {
                string romanDigit = romanRepresentation[currentPosition - 1];
                romanNumber = romanNumber + romanDigit;

                ushort arabicDigit = arabicRepresentation[currentPosition - 1];
                arabicNumber = arabicNumber - arabicDigit;
            }

            currentPosition--;
        }

        Console.WriteLine(romanNumber);
    }
}
