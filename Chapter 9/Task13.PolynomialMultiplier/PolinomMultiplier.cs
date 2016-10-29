using System;

class PolinomMultiplier
{
    static void Main(string[] args)
    {
        int[] firstPolynomial = InputPolynomialToArray();
        int[] secondPolynomial = InputPolynomialToArray();

        int[] polynomialResult = MultiplyPolynomialsToArray(firstPolynomial, secondPolynomial);

        PrintPolynomial(polynomialResult);
    }

    /// <summary>
    /// Multyplying two polynomials.
    /// </summary>
    /// <param name="polynomial01">First polynomial.</param>
    /// <param name="polynomial02">Second polynomial.</param>
    /// <returns>The result of multiplying</returns>
    public static int[] MultiplyPolynomialsToArray(int[] firstPolynomial, int[] secondPolynomial)
    {
        int polynomialResultLength = firstPolynomial.Length + secondPolynomial.Length - 1;
        int[] polynomialResult = new int[polynomialResultLength];

        for (int polynomial01Grade = 0;
             polynomial01Grade < firstPolynomial.Length;
             polynomial01Grade++)
        {
            for (int polynomial02Grade = 0;
                 polynomial02Grade < secondPolynomial.Length;
                 polynomial02Grade++)
            {
                int grade = polynomial01Grade + polynomial02Grade;
                int multiplier = firstPolynomial[polynomial01Grade] *
                                 secondPolynomial[polynomial02Grade];
                polynomialResult[grade] += multiplier;
            }
        }

        return polynomialResult;
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
        for (int i = polynomial.Length - 1; i >= 0; i--)
        {
            int sign = Math.Sign(polynomial[i]);
            string signSymbol = String.Empty;
            if (sign == -1)
            {
                signSymbol = "-";
            }
            else
            {
                signSymbol = "+";
            }
            if (i == polynomial.Length - 1 && signSymbol == "+")
            {
                Console.Write("{1}x^{2} ", signSymbol, Math.Abs(polynomial[i]), i);
            }
            else
            {
                Console.Write("{0} {1}x^{2} ", signSymbol, Math.Abs(polynomial[i]), i);
            }
        }
        Console.WriteLine();
    }
}
