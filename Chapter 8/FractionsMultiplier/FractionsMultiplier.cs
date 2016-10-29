using System;

class FractionsMultiplier
{
    static void Main(string[] args)
    {
        string inputNumber = Console.ReadLine();
        string inputMultiplicationCount = Console.ReadLine();
        int multiplyCount = int.Parse(inputMultiplicationCount);

        float floatNumber = float.Parse(inputNumber);
        float floatResult = 0;
        DateTime floatStartTime = DateTime.Now;
        for (int i = 0; i < multiplyCount; i++)
        {
            floatResult += floatNumber;
        }
        DateTime floatEndTime = DateTime.Now;
        TimeSpan floatTime = floatEndTime - floatStartTime;
        Console.WriteLine("{0} - {1}", floatTime, floatResult);

        double doubleNumber = double.Parse(inputNumber);
        double doubleResult = 0;
        DateTime doubleStartTime = DateTime.Now;
        for (int i = 0; i < multiplyCount; i++)
        {
            doubleResult += doubleNumber;
        }
        DateTime doubleEndTime = DateTime.Now;
        TimeSpan doubleTime = doubleEndTime - doubleStartTime;
        Console.WriteLine("{0} - {1}", doubleTime, doubleResult);

        decimal decimalNumber = decimal.Parse(inputNumber);
        decimal decimalResult = 0;
        DateTime decimalStartTime = DateTime.Now;
        for (int i = 0; i < multiplyCount; i++)
        {
            decimalResult += decimalNumber;
        }
        DateTime decimalEndTime = DateTime.Now;
        TimeSpan decimalTime = decimalEndTime - decimalStartTime;
        Console.WriteLine("{0} - {1}", decimalTime, decimalResult);
    }
}
