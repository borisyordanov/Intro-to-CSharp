using System;
using System.Threading;
using System.Linq;
using System.Globalization;

namespace Task8___CurrentDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture =
                    CultureInfo.GetCultureInfo("en-US");
            int year = int.Parse(Console.ReadLine());
            int month = int.Parse(Console.ReadLine());
            int day = int.Parse(Console.ReadLine());
            int hour = int.Parse(Console.ReadLine());
            int minute = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());

            Console.WriteLine(new DateTime(year, month, day, hour, minute, second));
        }
    }
}
