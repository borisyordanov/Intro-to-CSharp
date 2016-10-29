using System;

class PolynomialsSum
{
    static void Main(string[] args)
    {
        int[] firstPolynomial = InputPolynomialToArray();
        int[] secondPolynomial = InputPolynomialToArray();

        int[] polynomialSum = SumPolynomialsToArray(firstPolynomial, secondPolynomial);

        PrintPolynomial(polynomialSum);
    }

    /// <summary>
    /// Calculating the sum of two polynomials.
    /// </summary>
    /// <param name="polynomial01">First polynomial.</param>
    /// <param name="polynomial02">Second polynomial.</param>
    /// <returns>Return the sum of the two polynomials</returns>
    public static int[] SumPolynomialsToArray(int[] firstPolynomial, int[] secondPolynomial)
    {
        int maxLength = firstPolynomial.Length + 1;
        if (maxLength < secondPolynomial.Length)
        {
            maxLength = secondPolynomial.Length + 1;
        }
        int[] polynomialsSum = new int[maxLength];

        for (int i = 0; i < maxLength; i++)
        {
            polynomialsSum[i] = 0;
            if (i < firstPolynomial.Length) // checking if the polynomial is shorter or not
            {
                polynomialsSum[i] += firstPolynomial[i];
            }
            if (i < secondPolynomial.Length)
            {
                polynomialsSum[i] += secondPolynomial[i];
            }
        }

        return polynomialsSum;
    }

    /// <summary>
    /// Read polynomial from console.
    /// </summary>
    /// <returns>The polynomial as array of integers</returns>
    public static int[] InputPolynomialToArray()
    {
        string consoleInputPolynomial = Console.ReadLine();
        int polynomialCount = int.Parse(consoleInputPolynomial);
        int[] polynomial = new int[polynomialCount + 1];

        for (int i = polynomialCount; i >= 0; i--)
        {
            string inputValue = Console.ReadLine();
            polynomial[i] = int.Parse(inputValue);
        }

        return polynomial;
    }

    /// <summary>
    /// Prints the polynomial on the console.
    /// </summary>
    /// <param name="polynomial">The polynomial for printing.</param>
    public static void PrintPolynomial(int[] polynomial)
    {
        int highestGrade = polynomial.Length - 1;
        Console.Write("{0}x^{1}", polynomial[highestGrade], highestGrade);

        for (int i = highestGrade - 1; i >= 0; i--)
        {
            int sign = Math.Sign(polynomial[i]);
            if (sign != 0)
            {
                string signSymbol = null;
                if (sign == 1)
                {
                    signSymbol = "+";
                }
                else
                {
                    signSymbol = "-";
                }

                Console.Write(" {0} {1}x^{2}", signSymbol, Math.Abs(polynomial[i]), i);
            }
        }

        Console.WriteLine();
    }
}
