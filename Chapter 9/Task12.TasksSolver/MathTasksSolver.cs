using System;
using System.Threading;
using System.Globalization;

class MathTasksSolver
{
    static void Main(string[] args)
    {
        SolveTasksProcess();
    }

    static void SolveTasksProcess()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                ReverseDigitsOfANumberTask();
                break;
            case 2:
                AverageCalculationOfNumbersSequenceTask();
                break;
            case 3:
                SolvingLinearEquationTask();
                break;
            default:
                break;
        }
    }

    private static void ReverseDigitsOfANumberTask()
    {
        string inputNumber = Console.ReadLine();
        bool isNumberNegative = inputNumber.Contains("-");

        if (!isNumberNegative)
        {
            string reversedRepresentationOfANumber = Reversing(inputNumber);

            Console.WriteLine(reversedRepresentationOfANumber);
        }
        else
        {
            Console.WriteLine("Negative number!");
        }
    }

    private static string Reversing(string text)
    {
        string reversedString = null;
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reversedString = reversedString + text[i];
        }

        return reversedString;
    }

    private static void AverageCalculationOfNumbersSequenceTask()
    {
        string inputLengthOfSequence = Console.ReadLine();
        int lengthOfSequence = int.Parse(inputLengthOfSequence);

        if (lengthOfSequence > 0)
        {
            double[] numbersArray = new double[lengthOfSequence];

            for (int i = 0; i < lengthOfSequence; i++)
            {
                string inputNumber = Console.ReadLine();

                double number = double.Parse(inputNumber);

                numbersArray[i] = number;
            }

            double average = AverageCalculation(numbersArray);

            PrintResult(average);
        }
        else
        {
            Console.WriteLine("Empty sequence!");
        }
    }

    static double AverageCalculation(double[] elements)
    {
        double average;

        decimal sum = 0;

        foreach (double element in elements)
        {
            sum += (decimal)element;
        }

        average = (double)(sum / elements.Length);

        return average;
    }

    private static void SolvingLinearEquationTask()
    {
        string inputCoefficientA = Console.ReadLine();
        double coefficientA = double.Parse(inputCoefficientA);

        if (coefficientA != 0)
        {
            double coefficientB = double.Parse(Console.ReadLine());

            double x = SolveEquation(coefficientA, coefficientB);

            PrintResult(x);
        }
        else
        {
            Console.WriteLine("'A' is zero!");
        }
    }

    static double SolveEquation(double coefficientA, double coefficientB)
    {
        double x;

        if (coefficientB == 0)
        {
            x = 0;
        }
        else
        {
            x = -1 * coefficientB / coefficientA;
        }

        return x;
    }

    static void PrintResult(double result)
    {
        double fraction = result - (int)result;

        if (fraction.Equals(0))
        {
            Console.WriteLine("{0}", result);
        }
        else
        {
            Console.WriteLine("{0:0.00000}", result);
        }
    }
}
